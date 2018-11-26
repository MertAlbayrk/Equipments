using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demirbaş.DataModel;

namespace Demirbaş.Classes
{
    public class Software
    {

        public ReturnDto SoftwareAdd(string Name, string Status, DateTime PurchaseDate)
        {
            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    string kod;
                    int max_id = data.TB_Software.Max(p => p.ID);
                    kod = "Mt-" + max_id;



                    TB_Software m = new TB_Software();
                    m.UserCode = kod;
                    m.Name = Name;
                    m.Status = Status;
                    m.PurchaseDate = PurchaseDate;
                    m.KayitDurum = "Active";
                    data.TB_Software.Add(m);
                    data.SaveChanges();

                }
                return new ReturnDto(true, ReturnDto.Success);
            }
            catch (Exception)
            {

                return new ReturnDto(false, ReturnDto.Failed);
            }
        }

        public ReturnDto SoftwareUpdate(string SoftwareCode, string Name, string Status, DateTime PurchaseDate)

        {
            try

            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    var m = data.TB_Software.Where(p => p.UserCode == SoftwareCode).FirstOrDefault();
                    m.Name = Name;
                    m.PurchaseDate = PurchaseDate;
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

        public ReturnDto SoftwareDelete(string SoftwareCode)
        {
            try
            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {
                    var m = data.TB_Software.Where(p => p.UserCode == SoftwareCode).FirstOrDefault();
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