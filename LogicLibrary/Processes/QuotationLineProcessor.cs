using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    /// <summary>
    /// This class contains processes related to quotation details
    /// </summary>
    public class QuotationLineProcessor : IQuotationLineProcessor
    {
        /// <summary>
        /// This method saves a quotationline object into the the DB
        /// </summary>
        /// <param name="sale">this is a parameter of type quotations</param>
        public void SaveQuotationLine(IQuotations quotation)
        {
            foreach (var item in quotation.QuotationDetails)
            {
                var data = new
                {
                    ItemId = item.SelectedItem.Itemid,
                    QuotationId = quotation.QuotationId,
                    QuotationQuantity = item.QuotationQuantity,
                    RetailPrice = item.RetailPrice,
                    LineTotal = item.LineTotal
                };
                string sql = @"spQuotationLine_insert @ItemId,@QuotationId,@QuotationQuantity,@RetailPrice,@LineTotal";
                SqlDataAccess.RegisterData(sql, data);
            }
        }
    }
}
