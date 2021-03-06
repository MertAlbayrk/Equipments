﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demirbaş.DataModel;


namespace Demirbaş.Classes
{
    public class Notebook
    {
        public ReturnDto NotebooksAdd(string Users, string Vendor, string SerialNum, string PcName, string WifiMac, string EthMac, string OperationSystem, string Specification, string WindowsCdkey, string SSD, string SSDSerial, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {
            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    var t = data.TB_Notebooks.Where(p => p.SerialNum == SerialNum).Select(p => p.SerialNum).FirstOrDefault();
                    var t1 = data.TB_Notebooks.Where(p => p.EthMac == EthMac).Select(p => p.EthMac).FirstOrDefault();
                    var t2 = data.TB_Notebooks.Where(p => p.WifiMac == WifiMac).Select(p => p.WifiMac).FirstOrDefault();

                    if (SerialNum == t )
                    {
                        return new ReturnDto(false, ReturnDto.SerialError);
                    }
                    if (WifiMac == t2)
                    {
                        return new ReturnDto(false, ReturnDto.WifiErro);

                    }
                    if (EthMac == t1)
                    {
                        return new ReturnDto(false, ReturnDto.EthMac);
                    }

                    string kod;
                    int max_id = data.TB_Notebooks.Max(p => p.ID);
                    kod = "Mv-" + max_id;



                    TB_Notebooks m = new TB_Notebooks();
                    m.EthMac = EthMac;
                    m.InvoiceNumber = InvoiceNumber;
                    m.KayıtTarihi = DateTime.Now;
                    m.OldUser = OldUser;
                    m.OperationSystem = OperationSystem;
                    m.PcName = PcName;
                    m.PurchaseDate = PurchaseDate;
                    m.SerialNum = SerialNum;
                    m.Specification = Specification;
                    m.SSD = SSD;
                    m.SSDSerial = SSDSerial;
                    m.UserCode = kod;
                    m.Users = Users;
                    m.Vendor = Vendor;
                    m.WifiMac = WifiMac;
                    m.KayitDurum = "Active";
                    m.WindowsCdKey = WindowsCdkey;
                    data.TB_Notebooks.Add(m);
                    data.SaveChanges();

                }
                return new ReturnDto(true, ReturnDto.Success);
            }
            catch (Exception)
            {

                return new ReturnDto(false, ReturnDto.Failed);
            }
        }

        public ReturnDto NotebooksUpdate(string NotebooksCode, string Users, string Vendor, string SerialNum, string PcName, string WifiMac, string EthMac, string OperationSystem, string Specification, string WindowsCdkey, string SSD, string SSDSerial, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {
            try

            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    var m = data.TB_Notebooks.Where(p => p.UserCode == NotebooksCode).FirstOrDefault();
                    m.EthMac = EthMac;
                    m.InvoiceNumber = InvoiceNumber;
                    m.OldUser = OldUser;
                    m.OperationSystem = OperationSystem;
                    m.PcName = PcName;
                    m.PurchaseDate = PurchaseDate;
                    m.SerialNum = SerialNum;
                    m.Specification = Specification;
                    m.SSD = SSD;
                    m.SSDSerial = SSDSerial;
                    m.Users = Users;
                    m.Vendor = Vendor;
                    m.WifiMac = WifiMac;
                    m.WindowsCdKey = WindowsCdkey;
                    data.SaveChanges();

                }
                return new ReturnDto(true, ReturnDto.Success);
            }
            catch (Exception)
            {

                return new ReturnDto(false, ReturnDto.Failed);

            }


        }

        public ReturnDto NotebooksDelete(string NotebooksCode)
        {
            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {
                    var m = data.TB_Notebooks.Where(p => p.UserCode == NotebooksCode).FirstOrDefault();
                    m.KayitDurum = "Inactive";
                    data.SaveChanges();
                }
                return new ReturnDto(true, ReturnDto.Success);
            }
            catch (Exception)
            {
                return new ReturnDto(false, ReturnDto.Failed);
            }
        }




    }





}