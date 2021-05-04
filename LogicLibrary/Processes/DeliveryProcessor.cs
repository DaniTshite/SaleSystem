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
    /// This class contains processes relating to delivery
    /// </summary>
    public class DeliveryProcessor : IDeliveryProcessor
    {
        IDelivery _delivery;
        /// <summary>
        /// This method saves a delivery object into the DB
        /// </summary>
        /// <param name="delivery">This is an IDelivery object</param>
        /// <returns>It returns a string value</returns>
        public void SaveDelivery(IDelivery delivery)
        {
            try
            {
                _delivery = delivery;
                string sql = @"spDelivery_insert @DeliveryDate,@SaleId,@deliveryType,@DeliveryNumber,@DeliveryStatus";
                SqlDataAccess.RegisterData(sql, _delivery);
            }
            catch (Exception )
            {
                throw;
            }
        }
        /// <summary>
        /// This method gets all delivery objects from the DB
        /// </summary>
        /// <returns>It returns a list of delivery objects</returns>
        public List<Delivery> GetDeliveries()
        {
            try
            {
                string sql = @"spDelivery_GetAll";
                var p= SqlDataAccess.LoadData<Delivery>(sql);
                return p;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void UpdateDelivery(int saleId)
        {
            var data = new
            {
                SaleId = saleId
            };
            string sql = @"spDelivery_Update @SaleId";
            SqlDataAccess.RegisterData(sql,data);
        }
        
    }
}
