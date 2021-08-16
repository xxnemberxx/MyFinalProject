using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Products are Listed";
        public static string MaintenanceTime = "Sunucu bakımda";
        public static string ProductCountOfCategoryError = "Category product limit exceeded";
        public static string ProductNameAlreadyExists = "Bu ürün ismi zaten var";
        public static string CategoryLimitExceded = "Ürününüz eklenemiyor, Kategoriye ait ürün sınırınıza ulaştınız";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Kullanıcı adı ya da şifreniz hatalı";
        public static string SuccessfulLogin = "Başarıyla giriş yaptınız";
        public static string UserAlreadyExists = "Bu kullanıcı adı zaten var";
        public static string AccessTokenCreated = "Erişim jetonu oluşturuldu";
        public static string UserRegistered = "Başarıyla kayıt oldunuz.";
    }
}
