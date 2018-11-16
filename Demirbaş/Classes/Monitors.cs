using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demirbaş.DataModel;


namespace Demirbaş.Classes
{
    public class Monitors
    {
        public ReturnDto MonitorsAdd(string Demirbas, string Brand, string Users, string BrandFeatures, string Place, string Status, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {

            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    string kod;
                    int max_id = data.TB_Monitors.Max(p => p.ID);
                    kod = "Mt-" + max_id;



                    TB_Monitors m = new TB_Monitors();
                    m.UserCode = kod;
                    m.Demirbas = Demirbas;
                    m.Brand = Brand;
                    m.Users = Users;
                    m.BrandFeatures = BrandFeatures;
                    m.Place = Place;
                    m.Status = Status;
                    m.PurchaseDate = PurchaseDate;
                    m.InvoiceNumber = InvoiceNumber;
                    m.OldUser = OldUser;
                    data.TB_Monitors.Add(m);
                    data.SaveChanges();

                }
                return new ReturnDto(true, ReturnDto.Success);
            }
            catch (Exception)
            {

                return new ReturnDto(false, ReturnDto.Failed);
            }
        }

        public ReturnDto MonitorsUpdate(string MonitorsCode, string Demirbas, string Brand, string Users, string BrandFeatures, string Place, string Status, DateTime PurchaseDate, string InvoiceNumber, string Olduser)
        {
            try

            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    var m = data.TB_Monitors.Where(p => p.UserCode == MonitorsCode).FirstOrDefault();
                    m.Brand = Brand;
                    m.BrandFeatures = BrandFeatures;
                    m.Demirbas = Demirbas;
                    m.InvoiceNumber = InvoiceNumber;
                    m.OldUser = Olduser;
                    m.Place = Place;
                    m.PurchaseDate = PurchaseDate;
                    m.Status = Status;
                    m.Users = Users;
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