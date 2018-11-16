using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Demirbaş.DataModel;


namespace Demirbaş.Classes
{
    public class Servers
    {

            public ReturnDto ServersAdd(string ServerName, string Location,string SerialNumber)
            {
                try
                {
                    using (EquipmentsEntities data = new EquipmentsEntities())
                    {

                        string kod;
                        int max_id = data.TB_Servers.Max(p => p.ID);
                        kod = "Ms-" + max_id;



                        TB_Servers m = new TB_Servers();
                        m.ServerCode = kod;
                        m.ServerName = ServerName;
                        m.SerialNumber = SerialNumber;
                        m.Location = Location;
                        data.TB_Servers.Add(m);
                        data.SaveChanges();

                    }
                    return new ReturnDto(true, ReturnDto.Success);
                }
                catch (Exception)
                {

                    return new ReturnDto(false, ReturnDto.Failed);
                }
            }

        public ReturnDto ServersUpdate(string ServersCode,string ServerName, string Location, string SerialNumber)

        {
            try

            {
                using (EquipmentsEntities data = new EquipmentsEntities())
                {

                    var m = data.TB_Servers.Where(p => p.ServerCode == ServersCode).FirstOrDefault();
                    m.Location = Location;
                    m.SerialNumber = SerialNumber;
                    m.ServerCode = ServersCode;
                    m.ServerName = ServerName;
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