﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demirbaş.DataModel;

namespace Demirbaş.Controllers
{
    public class EquipmentController : Controller
    {
        // GET: Equipment
        public ActionResult Notebooks()
        {
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                ViewBag.notebookList = (from c in data.TB_Notebooks where c.KayitDurum == "Active" select c).ToList();
            }
            return View();
        }
        public ActionResult Servers()
        {
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                ViewBag.Servers = (from c in data.TB_Servers where c.KayitDurum == "Active" select c).ToList();
            }

            return View();
        }
        public ActionResult Printers()
        {
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                ViewBag.Printers = (from c in data.TB_Printers where c.KayitDurum == "Active" select c).ToList();
            }

            return View();
        }
        public ActionResult Monitors()
        {
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                ViewBag.Monitors = (from c in data.TB_Monitors where c.KayitDurum == "Active" select c).ToList();
            }

            return View();
        }
        public ActionResult Vınn()
        {
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                ViewBag.vin = (from c in data.TB_VINN where c.KayitDurum == "Active" select c).ToList();
            }

            return View();
        }
        public ActionResult Mobile()
        {
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                ViewBag.Mobile = (from c in data.TB_Mobile where c.KayitDurumu == "Active" select c).ToList();
            }

            return View();
        }
        public ActionResult Others()
        {
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                ViewBag.Others = (from c in data.TB_Others where c.KayitDurum == "Active" select c).ToList();
            }

            return View();
        }
        public ActionResult Software()
        {
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                ViewBag.Software = (from c in data.TB_Software where c.KayitDurum == "Active" select c).ToList();
            }

            return View();
        }

        public JsonResult NotebooksAdd(string Users, string Vendor, string SerialNum, string PcName, string WifiMac, string EthMac, string OperationSystem, DateTime PurchaseDate, string Specification, string WindowsCdKey, string SSD, string SSDSerial, string InvoiceNumber, string OldUser)
        {
            Classes.Notebook m = new Classes.Notebook();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = m.NotebooksAdd(Users, Vendor, SerialNum, PcName, WifiMac, EthMac, OperationSystem, Specification, WindowsCdKey, SSD, SSDSerial, PurchaseDate, InvoiceNumber, OldUser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult MonitorsAdd(string Demirbas, string MAC, string Brand, string Users,string SerialNumber, string BrandFeatures, string Place, string Status, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {
            Classes.Monitors m = new Classes.Monitors();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = m.MonitorsAdd(Users, Demirbas, Brand,SerialNumber,BrandFeatures, Place, Status, PurchaseDate, InvoiceNumber, OldUser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult MobileAdd(string Demirbas, string Name, string Phone, string Number, string SerialNumber, string IMEI, string MAC, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {
            Classes.Mobile s = new Classes.Mobile();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = s.mobileAdd(Demirbas, Name, Phone, Number, SerialNumber, IMEI, MAC, PurchaseDate, InvoiceNumber, OldUser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult OthersAdd(string Users, string Brand, string SerialNumber, string Features, string Location, string Specification, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {
            Classes.Others a = new Classes.Others();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = a.OthersAdd(Users, Brand, SerialNumber, Features, Location, Specification, PurchaseDate, InvoiceNumber, OldUser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult PrintersAdd(string Brand, string SerialNumber, string IP, string BasicFeatures, string NetworkName, string Location, DateTime PurchaseDate, string InventoryNumber, string Status, string InvoiceContract)
        {
            Classes.Printers v = new Classes.Printers();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = v.PrintersAdd(Brand, IP, BasicFeatures, SerialNumber, NetworkName, Location, InventoryNumber, InvoiceContract, Status, PurchaseDate);
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ServersAdd(string ServerName, string Location, string SerialNumber)
        {
            Classes.Servers s = new Classes.Servers();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = s.ServersAdd(ServerName, Location, SerialNumber);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SoftwareAdd(string Name, string Status, DateTime PurchaseDate)
        {
            Classes.Software o = new Classes.Software();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = o.SoftwareAdd(Name, Status, PurchaseDate);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult VınnAdd(string Users, string Operator, string IMEI, string SerialNumber, string DeviceName, string SımCardNo, string PIN1, string PIN2, string PUK1, string PUK2, string Special, string Status, DateTime PurchaseDate, string Olduser)
        {
            Classes.Vınn n = new Classes.Vınn();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = n.VınnAdd(Users, Operator, IMEI, SerialNumber, DeviceName, SımCardNo, PIN1, PIN2, PUK1, PUK2, Special, Status, PurchaseDate, Olduser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult mobileUpdate(string mobileCode, string Demirbas, string Name, string Phone, string Number, string SerialNumber, string IMEI, string MAC, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {
            Classes.Mobile s = new Classes.Mobile();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = s.mobileUpdate(mobileCode, Demirbas, Name, Phone, Number, SerialNumber, IMEI, MAC, PurchaseDate, InvoiceNumber, OldUser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult MobileDelete(string MobileCode)
        {
            Classes.Mobile v = new Classes.Mobile();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = v.MobileDelete(MobileCode);

            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult MonitorsUpdate(string MonitorsCode, string Demirbas, string Brand, string Users, string SerialNumber, string BrandFeatures, string Place, string Status, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {
            Classes.Monitors m = new Classes.Monitors();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = m.MonitorsUpdate(MonitorsCode,Demirbas,Brand,Users,SerialNumber,BrandFeatures,Place,Status,PurchaseDate,InvoiceNumber,OldUser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult MonitorsDelete(string MonitorsCode)
        {
            Classes.Monitors v = new Classes.Monitors();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = v.MonitorsDelete(MonitorsCode);

            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult NotebooksUpdate(string NotebooksCode, string Users, string Vendor, string SerialNum, string PcName, string WifiMac, string EthMac, string OperationSystem, DateTime PurchaseDate, string Specification, string WindowsCdKey, string SSD, string SSDSerial, string InvoiceNumber, string OldUser)
        {
            Classes.Notebook m = new Classes.Notebook();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = m.NotebooksUpdate(NotebooksCode, Users, Vendor, SerialNum, PcName, WifiMac, EthMac, OperationSystem, Specification, WindowsCdKey, SSD, SSDSerial, PurchaseDate, InvoiceNumber, OldUser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult NotebooksDelete(string NotebooksCode)
        {
            Classes.Notebook v = new Classes.Notebook();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = v.NotebooksDelete(NotebooksCode);

            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult OthersUpdate(string OthersCode, string Users, string Brand, string SerialNumber, string Features, string Location, string Specification, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {
            Classes.Others a = new Classes.Others();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = a.OthersUpdate(OthersCode, Users, Brand, SerialNumber, Features, Location, Specification, PurchaseDate, InvoiceNumber, OldUser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult OthersDelete(string OthersCode)
        {
            Classes.Others v = new Classes.Others();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = v.OthersDelete(OthersCode);

            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult PrintersUpdate(string PrintersCode, string Brand, string SerialNumber, string IP, string BasicFeatures, string NetworkName, string Location, DateTime PurchaseDate, string InventoryNumber, string Status, string InvoiceContract)
        {
            Classes.Printers v = new Classes.Printers();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = v.PrintersUpdate(PrintersCode, Brand, IP, BasicFeatures, SerialNumber, NetworkName, Location, InventoryNumber, InvoiceContract, Status, PurchaseDate);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult PrintersDelete(string PrintersCode)
        {
            Classes.Printers v = new Classes.Printers();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = v.PrintersDelete(PrintersCode);

            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ServersUpdate(string ServersCode, string ServerName, string Location, string SerialNumber)
        {
            Classes.Servers s = new Classes.Servers();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = s.ServersUpdate(ServersCode, ServerName, Location, SerialNumber);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ServersDelete(string ServersCode)
        {
            Classes.Servers s = new Classes.Servers();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = s.ServersDelete(ServersCode);

            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SoftwareUpdate(string SoftwareCode, string Name, string Status, DateTime PurchaseDate)
        {
            Classes.Software o = new Classes.Software();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = o.SoftwareUpdate(SoftwareCode, Name, Status, PurchaseDate);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SoftwareDelete(string softwareCode)
        {
            Classes.Software sf = new Classes.Software();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = sf.SoftwareDelete(softwareCode);

            return Json(r, JsonRequestBehavior.AllowGet);
        }
        public JsonResult VınnUpdate(string VınnCode, string Users, string Operator,string SerialNumber,string IMEI, string DeviceName,string SımCardNo, string PIN1, string PIN2, string PUK1, string PUK2, string Special, string Status, DateTime PurchaseDate, string Olduser)
        {
            Classes.Vınn n = new Classes.Vınn();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = n.VınnUpdate(VınnCode, Users, Operator,SerialNumber,IMEI, DeviceName, SımCardNo, PIN1, PIN2, PUK1, PUK2, Special, Status, PurchaseDate, Olduser);
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        public JsonResult VinDelete(string vincode)
        {
            Classes.Vınn v = new Classes.Vınn();
            Classes.ReturnDto r = new Classes.ReturnDto();

            r = v.VınnDelete(vincode);

            return Json(r, JsonRequestBehavior.AllowGet);

        }

    }
}
