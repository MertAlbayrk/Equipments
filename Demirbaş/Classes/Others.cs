using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demirbaş.DataModel;

namespace Demirbaş.Classes
{
    public class Others
    {
        public ReturnDto OthersAdd(string Users, string Brand, string SerialNumber, string Features, string Location, string Specification, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
            {
                try
                {
                    using (EquipmentsEntities data = new EquipmentsEntities())
                    {
                    var t = data.TB_Others.Where(p => p.SerialNumber == SerialNumber).Select(p => p.SerialNumber).FirstOrDefault();


                    if (SerialNumber == t)
                    {
                        return new ReturnDto(false, ReturnDto.SerialError);
                    }

                    else
                    {
                        string kod;
                        int max_id = data.TB_Others.Max(p => p.ID);
                        kod = "Mt-" + max_id;



                        TB_Others m = new TB_Others();
                        m.UserCode = kod;
                        m.Users = Users;
                        m.Brand = Brand;
                        m.SerialNumber = SerialNumber;
                        m.Users = Users;
                        m.Features = Features;
                        m.Location = Location;
                        m.Specification = Specification;
                        m.PurchaseDate = PurchaseDate;
                        m.InvoiceNumber = InvoiceNumber;
                        m.OldUser = OldUser;
                        m.KayitDurum = "Active";
                        m.PurchaseDate = PurchaseDate;
                        data.TB_Others.Add(m);
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


       public ReturnDto OthersUpdate(string OthersCode,string Users, string Brand, string SerialNumber, string Features, string Location, string Specification, DateTime PurchaseDate, string InvoiceNumber, string OldUser)
        {
            try

            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    var m = data.TB_Others.Where(p => p.UserCode == OthersCode).FirstOrDefault();
                    m.Brand = Brand;
                    m.Features = Features;
                    m.InvoiceNumber = InvoiceNumber;
                    m.Location = Location;
                    m.PurchaseDate = PurchaseDate;
                    m.OldUser = OldUser;
                    m.SerialNumber = SerialNumber;
                    m.Specification = Specification;
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

        public ReturnDto OthersDelete(string OthersCode)
        {
            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {
                    var m = data.TB_Others.Where(p => p.UserCode == OthersCode).FirstOrDefault();
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