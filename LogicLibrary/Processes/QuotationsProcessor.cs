using Dapper;
using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{

    /// <summary>
    /// This class contains processes relating to quotations
    /// </summary>
    public class QuotationsProcessor : IQuotationsProcessor
    {
        readonly IQuotationLineProcessor _quotationLineProcessor = ContainerConfig.CreateQuotationLineProcessor();
        private readonly Random _random = new Random();
        private bool _doesQuotationNumberExist = false;
        /// <summary>
        /// This method generate a random number for the quotation
        /// </summary>
        /// <returns>It returns an integer</returns>
        private int GenerateNumber()
        {
            return _random.Next(10000, 9999999);
        }
        /// <summary>
        /// This method validate the quotation number
        /// </summary>
        /// <returns>it returns an integer</returns>
        public int GetQuotationNumber()
        {
            int number = GenerateNumber();
            List<QuotationLine> listSales = GetQuotationDetails(number.ToString());
            while (!_doesQuotationNumberExist)
            {
                if (listSales != null || listSales.Count > 0)
                {
                    _doesQuotationNumberExist = true;
                }
                else
                {
                    number = GenerateNumber();
                }
            }
            return number;
        }
        /// <summary>
        /// this method saves a quotation object into the DB
        /// </summary>
        /// <param name="quotation">This is an IQuotation object </param>
        /// <returns>It returns a string </returns>
        public string SaveQuotation(IQuotations quotation)
        {
            using (IDbConnection cn = new SqlConnection(SqlDataAccess.GetConnectionString()))
            {
                try
                {
                    var data = new DynamicParameters();
                    data.Add("@QuotationNumber", quotation.QuotationNumber);
                    data.Add("@Discount", quotation.Discount);
                    data.Add("@SubTotal", quotation.SubTotal);
                    data.Add("@Tax", quotation.Tax);
                    data.Add("@Total", quotation.Total);
                    data.Add("@AccountId", 1);
                    data.Add("@UserId", 1);
                    data.Add("@QuotationId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    cn.Execute("spQuotations_insert", data, commandType: CommandType.StoredProcedure);
                    quotation.QuotationId = data.Get<int>("@QuotationId");
                    _quotationLineProcessor.SaveQuotationLine(quotation);
                    return "1 Record has been added Successfully ";
                }
                catch (Exception)
                {
                    return "An Error Occured";
                }
            }
        }
        /// <summary>
        /// This method get quotation details from the DB
        /// </summary>
        /// <param name="quotationNumber">This is a string representing the quotation number</param>
        /// <returns>It returns a list of QuotationLine objects</returns>
        public List<QuotationLine> GetQuotationDetails(string quotationNumber)
        {
            var output = SqlDataAccess.LoadQuotationData(quotationNumber);
            return output;
        }
        public List<Quotations> GetQuotations()
        {
            string sql = $"spQuotations_GetAll";
            return SqlDataAccess.LoadData<Quotations>(sql);
        }
    }
}
