using DataLibrary.Models;
using LogicLibrary.Processes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    /// <summary>
    /// this class is the container where objects are instantiated
    /// </summary>
    public static class ContainerConfig
    {
        //Data
        public static ISupplier CreateSupplier()
        {
            return new Supplier();
        }
        public static IUsers CreateUser()
        {
            return new Users();
        }
        public static IItem CreateItem()
        {
            return new Item();
        }
        public static ICategory CreateCategory()
        {
            return new Category();
        }
        public static IDelivery CreateDelivery()
        {
            return new Delivery();
        }
        public static ICustomerAccount CreateCustomerAccount()
        {
            return new CustomerAccount();
        }
        public static IOrderLine CreateOrderLine()
        {
            return new OrderLine();
        }
        public static IOrders CreateOrders()
        {
            return new Orders();
        }
        public static ISaleLine CreateSaleLine()
        {
            return new SaleLine();
        }
        public static ISales CreateSales()
        {
            return new Sales();
        }

        //Processors
        public static ICategoryProcessor CreateCategoryProcessor()
        {
            return new CategoryProcessor();
        }
        public static IDeliveryProcessor CreateDeliveryProcessor()
        {
            return new DeliveryProcessor();
        }
        public static IUsersProcessor CreateUsersProcessor()
        {
            return new UsersProcessor();
        }
        public static ISupplierProcessor CreateSupplierProcessor()
        {
            return new SupplierProcessor();
        }
        public static IItemProcessor CreateItemProcessor()
        {
            return new ItemProcessor();
        }
        public static IOrderLineProcessor CreateOrderLineProcessor()
        {
            return new OrderLineProcessor();
        }
        public static IOrdersProcessor CreateOrdersProcessor()
        {
            return new OrdersProcessor();
        }
        public static ISaleLineProcessor CreateSaleLineProcessor()
        {
            return new SaleLineProcessor();
        }
        public static ISalesProcessor CreateSalesProcessor()
        {
            return new SalesProcessor();
        }
        public static ICustomerAccountProcessor CreateCustomerAccountProcessor()
        {
            return new CustomerAccountProcessor();
        }
        public static IQuotationsProcessor CreateQuotationsProcessor()
        {
            return new QuotationsProcessor();
        }
    }
}
