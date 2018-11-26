using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demirbaş.DataModel;


namespace Demirbaş.Classes
{
    public class Printers
    {

        public ReturnDto PrintersAdd(string Brand, string IP, string BasicFeatures, string SerialNumber, string NetworkName, string Location, string InventoryNumber, string InvoiceContract, string Status, DateTime PurchaseDate)
        {
            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {
                    var t = data.TB_Printers.Where(p => p.SerialNumber == SerialNumber).Select(p => p.SerialNumber).FirstOrDefault();


                    if (SerialNumber == t)
                    {
                        return new ReturnDto(false, ReturnDto.SerialError);
                    }

                    else
                    {
                        string kod;
                        int max_id = data.TB_Printers.Max(p => p.ID);
                        kod = "Ma-" + max_id;



                        TB_Printers m = new TB_Printers();
                        m.UserCode = kod;
                        m.Brand = Brand;
                        m.IP = IP;
                        m.SerialNumber = SerialNumber;
                        m.BasicFeatures = BasicFeatures;
                        m.NetworkName = NetworkName;
                        m.Location = Location;
                        m.InventoryNumber = InventoryNumber;
                        m.InvoiceContract = InvoiceContract;
                        m.Status = Status;
                        m.PurchaseDate = PurchaseDate;
                        m.KayitDurum = "Active";
                        data.TB_Printers.Add(m);
                        data.SaveChanges();
                    }

                    

                }
                return new ReturnDto(true, ReturnDto.Success);
            }
            catch (Exception)
            {

                return new ReturnDto(false, ReturnDto.Failed);
            }
        }

        public ReturnDto PrintersUpdate(string PrintersCode, string Brand, string IP, string BasicFeatures, string SerialNumber, string NetworkName, string Location, string InventoryNumber, string InvoiceContract, string Status, DateTime PurchaseDate)
        {
            try

            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    var m = data.TB_Printers.Where(p => p.UserCode == PrintersCode).FirstOrDefault();
                    m.BasicFeatures = BasicFeatures;
                    m.Brand = Brand;
                    m.InventoryNumber = InventoryNumber;
                    m.InvoiceContract = InvoiceContract;
                    m.IP = IP;
                    m.Location = Location;
                    m.NetworkName = NetworkName;
                    m.PurchaseDate = PurchaseDate;
                    m.SerialNumber = SerialNumber;
                    m.Status = Status;
                    data.SaveChanges();


                }
                return new ReturnDto(true, ReturnDto.Success);
            }
            catch (Exception)
            {

                return new ReturnDto(false, ReturnDto.Failed);

            }


        }



        public ReturnDto PrintersDelete(string PrintersCode)
        {
            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {
                    var m = data.TB_Printers.Where(p => p.UserCode == PrintersCode).FirstOrDefault();
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