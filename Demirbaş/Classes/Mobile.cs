using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demirbaş.DataModel;

namespace Demirbaş.Classes
{
    public class Mobile
    {
        public ReturnDto mobileAdd(string Demirbas, string Name, string Phone, string Number, string SerialNumber, string IMEI, string MAC, DateTime PurchaseDate, string InvInvoiceNumber, string Olduser)
        {
            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    string kod;
                    int max_id = data.TB_Mobile.Max(p => p.ID);
                    kod = "M-" + max_id;



                    TB_Mobile m = new TB_Mobile();
                    m.UserCode = kod;
                    m.Demirbas = Demirbas;
                    m.Name = Name;
                    m.Phone = Phone;
                    m.Number = Number;
                    m.SerialNumber = SerialNumber;
                    m.IMEI = IMEI;
                    m.MAC = MAC;
                    m.PurchaseDate = PurchaseDate;
                    m.InvoiceNumber = InvInvoiceNumber;
                    m.OldUser = Olduser;
                    data.TB_Mobile.Add(m);
                    data.SaveChanges();

                }
                return new ReturnDto(true, ReturnDto.Success);
            }
            catch (Exception)
            {

                return new ReturnDto(false, ReturnDto.Failed);
            }
        }

        public ReturnDto mobileUpdate(string mobileCode, string Demirbas, string Name, string Phone, string Number, string SerialNumber, string IMEI, string MAC, DateTime PurchaseDate, string InvInvoiceNumber, string Olduser)
        {
            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {
                    var m = data.TB_Mobile.Where(p => p.UserCode == mobileCode).FirstOrDefault();
                    m.Demirbas = Demirbas;
                    m.IMEI = IMEI;
                    m.InvoiceNumber = InvInvoiceNumber;
                    m.MAC = MAC;
                    m.Name = Name;
                    m.Number = Number;
                    m.OldUser = Olduser;
                    m.Phone = Phone;
                    m.PurchaseDate = PurchaseDate;
                    m.SerialNumber = SerialNumber;
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