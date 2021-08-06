using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Prdouct Added";
        public static string ProductNameInvalid = "Product name invalid";
        public static string ProductsListed = "Products are Listed";
        public static string MaintenanceTime = "Server in maintenance";
        public static string ProductCountOfCategoryError = "Category product limit exceeded";
        public static string ProductNameAlreadyExists = "Product name already exists";
        public static string CategoryLimitExceded = "Unable to add product because category limit has been exceeded";
    }
}
