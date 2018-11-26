using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demirbaş.ViewModel;
using PagedList;
using Demirbaş.DataModel;
namespace Demirbaş.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Notebooks(NotebookModel model)
        {
            int pageIndex = model.Page ?? 1;
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                model.NotebookSearch = (from c in data.TB_Notebooks.Where(p => p.KayitDurum  == "Active" && (String.IsNullOrEmpty(model.Users) || p.Users.Contains(model.Users)) &&
                                      (String.IsNullOrEmpty(model.SerialNumber) || p.SerialNum.Contains(model.SerialNumber))).OrderByDescending(p => p.ID)
                                      select new NotebookListModel
                                      {
                                       EthMac = c.EthMac,
                                       InvoiceNumber = c.InvoiceNumber,
                                       OldUser = c.OldUser,
                                       PcName = c.PcName,
                                       SerialNum = c.SerialNum,
                                       PurchaseDate = c.PurchaseDate,
                                       Specification = c.Specification,
                                       SSD = c.SSD,
                                       SSDSerial =c.SSDSerial,
                                       UserCode = c.UserCode,
                                       Users = c.Users,
                                       Vendor =c.Vendor,
                                       WifiMac =c.WifiMac,
                                       WindowsCdKey =c.WindowsCdKey
                                      }).ToPagedList(pageIndex, 15);
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Notebook", model);

                }
                else
                {
                    return View(model);
                }
            }
        }
        public ActionResult Servers(ServersModel model)
        {
            int pageIndex = model.Page ?? 1;
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                model.ServersSearch = (from c in data.TB_Servers.Where(p => p.KayitDurum == "Active" && (String.IsNullOrEmpty(model.SerialNumber) || p.SerialNumber.Contains(model.SerialNumber))).OrderByDescending(p => p.ID)
                                       select new ServersListModel
                                       {
                                          Location = c.Location,
                                          Serialnumber = c.SerialNumber,
                                          ServerName = c.ServerName,
                                           UserCode = c.ServerCode
                                       }).ToPagedList(pageIndex, 15);
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Servers", model);

                }
                else
                {
                    return View(model);
                }
            }
        }
        public ActionResult Printers(PrinterModel model)
        {
            int pageIndex = model.Page ?? 1;
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                model.PrinterSearch = (from c in data.TB_Printers.Where(p => p.KayitDurum == "Active" && (String.IsNullOrEmpty(model.SerialNumber) || p.SerialNumber.Contains(model.SerialNumber))).OrderByDescending(p => p.ID)
                                        select new PrinterListModel
                                        {
                                            BasicFeatures = c.BasicFeatures,
                                            SerialNumber = c.SerialNumber,
                                            Brand = c.Brand,
                                            InventoryNumber = c.InventoryNumber,
                                            InvoiceContract = c.InvoiceContract,
                                             IP = c.IP,
                                             Location = c.Location,
                                             NetworkName = c.NetworkName,
                                             PurchaseDate = c.PurchaseDate,
                                             Status = c.Status,
                                             UserCode = c.UserCode
                                        }).ToPagedList(pageIndex, 15);
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Printer", model);

                }
                else
                {
                    return View(model);
                }
            }
        }
        public ActionResult Monitors(MonitorModel model)
        {
            int pageIndex = model.Page ?? 1;
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                model.MonitorSearch = (from c in data.TB_Monitors.Where(p => p.KayitDurum == "Active" && (String.IsNullOrEmpty(model.Users) || p.Users.Contains(model.Users)) &&
                                      (String.IsNullOrEmpty(model.SerialNumber) || p.SerialNumber.Contains(model.SerialNumber))).OrderByDescending(p => p.ID)
                                   select new MonitorListModel
                                   {
                                       BasicFeatures =c.BrandFeatures,
                                       Brand = c.Brand,
                                       Demirbas = c.Demirbas,
                                       InvoiceNumber = c.InvoiceNumber,
                                       OldUser = c.OldUser,
                                       Place =c.Place,
                                       PurchaseDate = c.PurchaseDate,
                                       SerialNumber = c.SerialNumber,
                                       Status = c.Status,
                                       UserCode = c.UserCode,
                                       Users = c.Users
                                   }).ToPagedList(pageIndex, 15);
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Monitor", model);

                }
                else
                {
                    return View(model);
                }
            }
        }
        public ActionResult Vınn(VinModel model)
        {
            int pageIndex = model.Page ?? 1;
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                model.VinSearch = (from c in data.TB_VINN.Where(p => p.KayitDurum == "Active" && (String.IsNullOrEmpty(model.Users) || p.Users.Contains(model.Users)) &&
                                      (String.IsNullOrEmpty(model.SerialNumber) || p.SerialNumber.Contains(model.SerialNumber))).OrderByDescending(p => p.ID)
                                      select new VinListModel
                                      {
                                         Users = c.Users,
                                         DeviceName=c.DeviceName,
                                         IMEI = c.IMEI,
                                         OldUser = c.OldUser,
                                         Operator = c.Operator,
                                         PIN1 = c.PIN1,
                                         PIN2 = c.PIN2,
                                         PUK1 = c.PUK1,
                                         PUK2 = c.PUK2,
                                         PurchaseDate = c.PurchaseDate,
                                         SerialNumber = c.SerialNumber,
                                         Special = c.Special,
                                         Status = c.Status, 
                                          SımCardNo = c.SımCardNo,
                                          UserCode = c.UserCode
                                      }).ToPagedList(pageIndex, 15);
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Vinn", model);

                }
                else
                {
                    return View(model);
                }
            }
        }
        public ActionResult Mobile(MobileModel model)
        {
            int pageIndex = model.Page ?? 1;
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                model.MobileSearch = (from c in data.TB_Mobile.Where(p => p.KayitDurumu == "Active" && (String.IsNullOrEmpty(model.Users) || p.Name.Contains(model.Users)) &&
                                      (String.IsNullOrEmpty(model.SerialNumber) || p.SerialNumber.Contains(model.SerialNumber))).OrderByDescending(p => p.ID)
                                      select new MobileListModel
                                      {
                                          Demirbas = c.Demirbas,
                                          IMEI = c.IMEI,
                                          InvoiceNumber = c.InvoiceNumber,
                                          MAC = c.MAC,
                                          Name = c.Name,
                                          Number = c.Number,
                                          OldUser = c.OldUser,
                                          Phone = c.Phone,
                                          PurchaseDate = c.PurchaseDate,
                                          SerialNumber = c.SerialNumber,
                                          UserCode = c.UserCode
                                      }).ToPagedList(pageIndex, 15);
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Mobile", model);

                }
                else
                {
                    return View(model);
                }
            }
        }
        public ActionResult Others(OtherModel model)
        {
            int pageIndex = model.Page ?? 1;
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                model.OtherSearch = (from c in data.TB_Others.Where(p => p.KayitDurum == "Active" && (String.IsNullOrEmpty(model.Users) || p.Users.Contains(model.Users)) &&
                                      (String.IsNullOrEmpty(model.SerialNumber) || p.SerialNumber.Contains(model.SerialNumber))).OrderByDescending(p => p.ID)
                                      select new OtherListModel
                                      {
                                         Users = c.Users,
                                         Brand = c.Brand,
                                         Features = c.Features,
                                         InvoiceNumber = c.InvoiceNumber,
                                         Location = c.Location,
                                         OldUser = c.OldUser,
                                         PurchaseDate =c.PurchaseDate,
                                         SerialNumber =c.SerialNumber,
                                         Specification = c.Specification,
                                         UserCode =c.UserCode,

                                      }).ToPagedList(pageIndex, 15);
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Others", model);

                }
                else
                {
                    return View(model);
                }
            }
        }
        public ActionResult Software(SoftwareModel model)
        {
            int pageIndex = model.Page ?? 1;
            using (EquipmentsEntities data = new EquipmentsEntities())
            {
                model.softwareSearch = (from c in data.TB_Software.Where(p => p.KayitDurum == "Active" && (String.IsNullOrEmpty(model.Name) || p.Name.Contains(model.Name))).OrderByDescending(p => p.ID)
                                        select new SoftwareListModel
                                        {
                                            Name = c.Name,
                                            PurchaseteDate = c.PurchaseDate,
                                            Status = c.Status,
                                            UserCode = c.UserCode
                                        }).ToPagedList(pageIndex, 15);
                if (Request.IsAjaxRequest())
                {
                    return PartialView("_Software", model);

                }
                else
                {
                    return View(model);
                }
            }
        }
    }
}