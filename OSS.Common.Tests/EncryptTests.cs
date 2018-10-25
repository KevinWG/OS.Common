﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSS.Common.Authrization;
using OSS.Common.ComUtils;
using OSS.Common.Encrypt;
using OSS.Common.Extention;

namespace OSS.Common.Tests
{
    [TestClass]
    public class EncryptTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }


        [TestMethod]
        public  void SysAuth()
        {
            var key = Guid.NewGuid().ToString().Replace("-", string.Empty);

            var appInfo = new AppAuthorizeInfo
            {
                AppClient = AppClientType.Android,
                AppSource = "mmmmm",
                AppVersion = "1.0.1",
                DeviceId = "mmnsnd",
                Token = "SeBCjJYRkujxEsgv9XupyHY7aMkdQuQcqGMu0wQMbhw=",
                IpAddress = "127.0.0.1"
            };

            var newSignData = appInfo.ToTicket(key);
            appInfo.FromTicket(newSignData);

            var result = appInfo.CheckSign(key);
        }

        [TestMethod]
        public void EncryptTest()
        {
            var timeUtc = DateTime.Now.ToUtcMilliSeconds();
            var result = Md5.EncryptHexString("1389085779854n35a5fdhawz56y24pjn3u9d5zp9r1nhpebrxyyu359cq0ddo");
            //var page = new PageListModel<AppAuthorizeInfo>(100, new List<AppAuthorizeInfo>(), new
            //        SearchModel() {});
        }

        [TestMethod]
        public void Sha1Test()
        {
            string str1 = Sha1.Encrypt("这是一个测试");
        }

        [TestMethod]
        public void Encrypt()
        {
            string key = Guid.NewGuid().ToString().Replace("-", string.Empty);

            string result = AesRijndael.Encrypt("owxehuN4Ntt8Gx0AqBJ6O6Jv27Yg", key);

            string r = AesRijndael.Decrypt(result, key);

            

        }

    }


}
