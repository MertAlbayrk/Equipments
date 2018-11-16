using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demirbaş.DataModel;

namespace Demirbaş.Classes
{
    public class Vınn
    {

            public ReturnDto VınnAdd(string Users, string Operator,string SerialNumber, string IMEI, string DeviceName, string SımCardNo, string PIN1, string PIN2, string PUK1, string PUK2, string Special, string Status, DateTime PurchaseDate, string Olduser)
            {
                try
                {
                    using (EquipmentsEntities data = new EquipmentsEntities())
                    {

                        string kod;
                        int max_id = data.TB_VINN.Max(p => p.ID);
                        kod = "Mt-" + max_id;



                        TB_VINN m = new TB_VINN();
                        m.UserCode = kod;
                        m.Users = Users;
                        m.Operator = Operator;
                        m.SerialNumber = SerialNumber;
                        m.IMEI = IMEI;
                        m.DeviceName = DeviceName;
                        m.SımCardNo = SımCardNo;
                        m.PIN1 = PIN1;
                        m.PIN2 = PIN2;
                        m.PUK1 = PUK1;
                        m.PUK2 = PUK2;
                        m.Special = Special;
                        m.Status =Status;
                        m.PurchaseDate = PurchaseDate;
                        m.OldUser = Olduser;
                        data.TB_VINN.Add(m);
                        data.SaveChanges();

                    }
                    return new ReturnDto(true, ReturnDto.Success);
                }
                catch (Exception)
                {

                    return new ReturnDto(false, ReturnDto.Failed);
                }
            }

        public ReturnDto VınnUpdate(string VınnCode,string Users, string Operator, string SerialNumber, string IMEI, string DeviceName, string SımCardNo, string PIN1, string PIN2, string PUK1, string PUK2, string Special, string Status, DateTime PurchaseDate, string Olduser)

        {
            try

            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    var m = data.TB_VINN.Where(p => p.UserCode == VınnCode).FirstOrDefault();
                    m.IMEI = IMEI;
                    m.DeviceName = DeviceName;
                    m.OldUser = Olduser;
                    m.Operator = Operator;
                    m.PIN1 = PIN1;
                    m.PIN2 = PIN2;
                    m.PUK1 = PUK1;
                    m.PUK2 = PUK2;
                    m.PurchaseDate = PurchaseDate;
                    m.SerialNumber = SerialNumber;
                    m.Special = Special;
                    m.Status = Status;
                    m.SımCardNo = SımCardNo;
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
