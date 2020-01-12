using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SOHATS
{
    public class SqlConnectionClass
    {
        List<string> processes = new List<string>(); //processes in hospital and their fees

        /*"Data Source=DESKTOP-QSVT225;Initial Catalog=SOHATS;Persist Security Info=True;User ID=sa;Password=zinagafsa29"*/
        //static string connectionAddress =  @"Server=.\;Database=SOHATS;User Id=sa;;Password=zinagafsa29";
        static string connectionAddress = @"Server=.\;Database=SOHATS;Trusted_Connection=True";
        public SqlConnection connection = new SqlConnection(connectionAddress);
        SqlDataAdapter sda;
        public SqlCommand cmd;
        public DataTable dtbl;
        public SqlDataReader dr;


        string query;
        public void KullanıcıInsertOrUpdateData()
        {
            
            connection.Open();
            string code = Kullanıcı.UserCode;

            string query = @"IF EXISTS(SELECT * FROM kullanici WHERE kodu = '"
                + code + "') UPDATE kullanici SET ad='" + Kullanıcı.Name + "',soyad = '" +Kullanıcı.SurName+ "',sifre = '" +Kullanıcı.Password+ "',yetki = '"
                + Kullanıcı.AuthorizedUser + "',evtel= '" + Kullanıcı.Gsm + "',ceptel='" + Kullanıcı.PhoneNumber + "',adres='" + Kullanıcı.Address+ "',unvan= '"
                + Kullanıcı.Title+ "' ,isebaslama= '" + Kullanıcı.JobStartDate + "',maas='" + Kullanıcı.Salary + "',dogumyeri='" + Kullanıcı.BirthPlace + "',annead='"
                + Kullanıcı.MotherName+ "',babaad='" + Kullanıcı.FatherName + "',cinsiyet='" + Kullanıcı.Gender + "',kangrubu='"
                + Kullanıcı.BloodGroup+ "',medenihal='" + Kullanıcı.MaritalStatus + "',dogumtarihi='" + Kullanıcı.BirthDay + "',tckimlikno='" + Kullanıcı.IdentityNo + "',username='"
                + Kullanıcı.UserName + "' WHERE kodu = '"
                + code + "' ELSE insert into kullanici(ad,soyad,sifre,yetki,evtel,ceptel,adres,unvan,isebaslama,maas,dogumyeri,annead,babaad,cinsiyet,kangrubu,medenihal,dogumtarihi,tckimlikno,username)values('" 
                + Kullanıcı.Name + "','" + Kullanıcı.SurName + "','" + Kullanıcı.Password+ "','" + Kullanıcı.AuthorizedUser+ "','" + Kullanıcı.Gsm + "','" + Kullanıcı.PhoneNumber + "','"
                        + Kullanıcı.Address + "','" + Kullanıcı.Title + "','" + Kullanıcı.JobStartDate + "','" + Kullanıcı.Salary + "','" + Kullanıcı.BirthPlace + "','" + Kullanıcı.MotherName + "','" + Kullanıcı.FatherName + "','" + Kullanıcı.Gender + "','" + Kullanıcı.BloodGroup + "','"
                        + Kullanıcı.MaritalStatus + "','" + Kullanıcı.BirthDay + "','" + Kullanıcı.IdentityNo + "','" + Kullanıcı.UserName+ "');";

            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            
            connection.Close();

        }
        public void KullanıcıDeleteData()
        {
            string code = Kullanıcı.UserCode;

            query = "delete from kullanici where kodu='" + code + "'";

            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void KullanıcıBringData()
        {
            string userName = KulTanit.username;
            query = "Select * From kullanici where username=@order";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@order", userName);
            connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Kullanıcı.UserCode = dr["kodu"].ToString();
                Kullanıcı.Name = dr["ad"].ToString();
                Kullanıcı.SurName = dr["soyad"].ToString();
                Kullanıcı.Password = dr["sifre"].ToString();
                Kullanıcı.AuthorizedUser = Convert.ToBoolean(dr["yetki"]);
                Kullanıcı.Gsm = dr["evtel"].ToString();
                Kullanıcı.PhoneNumber = dr["ceptel"].ToString();
                Kullanıcı.Address = dr["adres"].ToString();
                Kullanıcı.Title = dr["unvan"].ToString();
                Kullanıcı.JobStartDate = Convert.ToDateTime(dr["isebaslama"]);
                Kullanıcı.Salary = dr["maas"].ToString();
                Kullanıcı.BirthPlace = dr["dogumyeri"].ToString();
                Kullanıcı.MotherName = dr["annead"].ToString();
                Kullanıcı.FatherName = dr["babaad"].ToString();
                Kullanıcı.Gender = dr["cinsiyet"].ToString();
                Kullanıcı.BloodGroup = dr["kangrubu"].ToString();
                Kullanıcı.MaritalStatus = dr["medenihal"].ToString();
                Kullanıcı.BirthDay = Convert.ToDateTime(dr["dogumtarihi"].ToString());
                Kullanıcı.IdentityNo = dr["tckimlikno"].ToString();
                Kullanıcı.UserName = dr["username"].ToString();
            }

            connection.Close();
        }

        public void PoliklinikInsertOrUpdateData()
        {
            connection.Open();
            string query = @"IF EXISTS(SELECT * FROM polikinlik WHERE polikinlikadi = '" + Poliklinik.PolycilinicName + "') UPDATE polikinlik SET durum='" + Poliklinik.Situation + "',aciklama = '" + Poliklinik.Explanation + "'  WHERE polikinlikadi = '"
                + Poliklinik.PolycilinicName + "' ELSE INSERT INTO polikinlik(polikinlikadi,durum,aciklama) VALUES('" + Poliklinik.PolycilinicName + "','" + Poliklinik.Situation + "','" + Poliklinik.Explanation + "');";
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();


        }
        public void PoliklinikBringData()
        {

            string polyclinicName = PoliTanıt.polyclinicName;
            query = "Select * From polikinlik where polikinlikadi=@order";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@order", polyclinicName);

            
            SqlDataReader dr;
            connection.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Poliklinik.PolycilinicName= dr["polikinlikadi"].ToString();
                Poliklinik.Situation = Convert.ToBoolean(dr["durum"].ToString());
                Poliklinik.Explanation = dr["aciklama"].ToString();

            }

            connection.Close();

        }
        public void PoliklinikDeleteData()
        {
            query = "delete from polikinlik where polikinlikadi='" + Poliklinik.PolycilinicName + "'";
            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

        }               

        public void TaburcuInsertOrUpdateData()
        {
           /* @"IF EXISTS(SELECT * FROM cikis WHERE dosyano= '" + Taburcu.FileNo + "') UPDATE cikis SET sevktarihi='" + Taburcu.DisPatchDate + "',cikissaati= '"
                + Taburcu.ExitDate + "',odeme='" + Taburcu.PaymentRate + "',toplamtutar='" + Taburcu.TotalFee + "'  WHERE dosyano = '"
                + Taburcu.FileNo + "' ELSE */
            string query = "INSERT INTO cikis(dosyano,sevktarihi,cikissaati,odeme,toplamtutar) VALUES('" + Taburcu.FileNo + "','"
                + Taburcu.DisPatchDate + "','" + Taburcu.ExitDate + "','" + Taburcu.PaymentRate + "','" + Taburcu.TotalFee + "');";
            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();

        }

        public void HastaBilgileriInsertOrUpdateData()
        {
            connection.Open();
            query = @"IF EXISTS(SELECT * FROM hasta WHERE dosyano = '" + HastaBilgileri.FileNo + "') UPDATE hasta SET tckimlikno='"+HastaBilgileri.Identity+"',ad= '"
                + HastaBilgileri.PatientName + "',soyad='" + HastaBilgileri.PatientSurName + "',dogumyeri='" + HastaBilgileri.BirthPlace + "',dogumtarihi='" + HastaBilgileri.BirthDay+ "',babaadi='"
                + HastaBilgileri.FatherName + "',anneadi='" + HastaBilgileri.MotherName + "',cinsiyet='" + HastaBilgileri.Gender + "',kangrubu='" + HastaBilgileri.BloodGroup + "',medenihal='"
                + HastaBilgileri.MaritalStatus + "',adres='" + HastaBilgileri.Address + "',tel='" + HastaBilgileri.PhoneNumber + "',kurumsicilno='"
            + HastaBilgileri.InstutionRegisteryNumber + "',kurumadi='" + HastaBilgileri.InstutionName + "',yakintel='" + HastaBilgileri.CloseRelativePhoneNumber + "',yakinkurumsicilno='"
            + HastaBilgileri.CloseRelativeInstutionRegisteryNumber + "',yakinkurumadi='" + HastaBilgileri.CloseRelativeInstutionName + "' WHERE dosyano = '" + HastaBilgileri.FileNo +
            "' ELSE INSERT INTO hasta(tckimlikno,ad,soyad,dogumyeri,dogumtarihi,babaadi,anneadi,cinsiyet,kangrubu,medenihal,adres,tel,kurumsicilno,kurumadi,yakintel,yakinkurumsicilno,yakinkurumadi) VALUES('"
            +HastaBilgileri.Identity+"','" + HastaBilgileri.PatientName + "','" + HastaBilgileri.PatientSurName + "','" + HastaBilgileri.BirthPlace + "','" + HastaBilgileri.BirthDay+ "','"
                + HastaBilgileri.FatherName + "','" + HastaBilgileri.MotherName + "','" + HastaBilgileri.Gender + "','" + HastaBilgileri.BloodGroup + "','"
                + HastaBilgileri.MaritalStatus + "','" + HastaBilgileri.Address + "','" + HastaBilgileri.PhoneNumber + "','"
            + HastaBilgileri.InstutionRegisteryNumber + "','" + HastaBilgileri.InstutionName + "','" + HastaBilgileri.CloseRelativePhoneNumber + "','"
            + HastaBilgileri.CloseRelativeInstutionRegisteryNumber + "','" + HastaBilgileri.CloseRelativeInstutionName + "');";

            
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public void HastaBilgileriBringData()
        {
            query = "Select * From hasta where dosyano=@order";
            string FileNo = Hastaİslemleri.FileNo;
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@order", FileNo);
            SqlDataReader dr;
            connection.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                HastaBilgileri.Identity = dr["tckimlikNo"].ToString();
                FileNo = dr["dosyano"].ToString();
                HastaBilgileri.PatientName= dr["ad"].ToString();
                HastaBilgileri.PatientSurName= dr["soyad"].ToString();
                HastaBilgileri.BirthPlace = dr["dogumyeri"].ToString();
                HastaBilgileri.BirthDay = Convert.ToDateTime(dr["dogumtarihi"]);
                HastaBilgileri.FatherName = dr["babaadi"].ToString();
                HastaBilgileri.MotherName = dr["anneadi"].ToString();
                HastaBilgileri.Gender = dr["cinsiyet"].ToString();
                HastaBilgileri.BloodGroup = dr["kangrubu"].ToString();
                HastaBilgileri.MaritalStatus = dr["medenihal"].ToString();
                HastaBilgileri.Address = dr["adres"].ToString();
                HastaBilgileri.PhoneNumber = dr["tel"].ToString();
                HastaBilgileri.InstutionRegisteryNumber = dr["kurumsicilno"].ToString();
                HastaBilgileri.InstutionName = dr["kurumadi"].ToString();
                HastaBilgileri.CloseRelativePhoneNumber = dr["yakintel"].ToString();
                HastaBilgileri.CloseRelativeInstutionRegisteryNumber = dr["yakinkurumsicilno"].ToString();
                HastaBilgileri.CloseRelativeInstutionName = dr["yakinkurumadi"].ToString();
            }

            connection.Close();
        }
        public void HastaİslemleriBringDataFromHastaTable()
        {

            string fileNo = Hastaİslemleri.FileNo;
            query = "Select * From hasta where dosyano=@order";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@order", fileNo);
            connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Hastaİslemleri.FileNo = dr["dosyano"].ToString();
                Hastaİslemleri.PatientName = dr["ad"].ToString();
                Hastaİslemleri.PatientSurname = dr["soyad"].ToString();
                Hastaİslemleri.InstutionName = dr["kurumadi"].ToString();
            }
            connection.Close();
        }
        public void HastaİslemleriBringDataFromSevkTable()
        {          
            string fileNo = Hastaİslemleri.FileNo;
            query = "Select * From cikis where dosyano=@order";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@order", fileNo);
            connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Hastaİslemleri.DispatchDate = Convert.ToDateTime(dr["sevktarihi"]);
                Hastaİslemleri.previousProcesses.Add(dr["sevktarihi"].ToString());
            }
            
            connection.Close();
            if (Hastaİslemleri.DispatchDate == Convert.ToDateTime("1/1/0001 12:00:00 AM"))
            {
                Hastaİslemleri.DispatchDate = DateTime.Now;
            }

        }
        public void HastaİslemleriProcessesData()
        {

            query = "Select * From islem";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr;
            connection.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Hastaİslemleri.processToDo.Add( dr["islemAdi"].ToString());
                //Hastaİslemleri.UnitFee = dr["birimFiyat"].ToString();
            }
            
            connection.Close();
        }
        public void HastaİslemleriFeeData()
        {
            string processName = Hastaİslemleri.ProcessToDo;
            query = "Select * From islem where islemAdi=@order";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader dr;
            cmd.Parameters.AddWithValue("@order", processName);
            connection.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Hastaİslemleri.UnitFee = dr["birimFiyat"].ToString();
            }

            connection.Close();
        }
        public void HastaİslemleriQueueNumber(){

           query = "SELECT MAX(sıra) FROM sevk WHERE polikinlik = @order and sevktarihi = @date";
           string polyclinic = Hastaİslemleri.Polyclinic;

           string dispatchDate = Hastaİslemleri.DispatchDate.ToShortDateString();
           cmd = new SqlCommand(query, connection);
           cmd.Parameters.AddWithValue("@date", dispatchDate);
           cmd.Parameters.AddWithValue("@order", polyclinic);

           connection.Open();
           Hastaİslemleri.QueueNumber = cmd.ExecuteScalar().ToString();
           connection.Close();
        }
        public void HastaİslemleriDoctorCode()
        {
            query = "SELECT * FROM kullanici WHERE unvan = @order ";
            string title = "Doktor";
            cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@order", title);
            connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Hastaİslemleri.doctorCode.Add(dr["kodu"].ToString());
            }         
            connection.Close();

        }
        public void HastaİslemleriDeleteData()
        {
            query = "Delete from sevk where polikinlik='" + Hastaİslemleri.Polyclinic + "' and sevktarihi = '"
                + Hastaİslemleri.DispatchDate.ToShortDateString() + "' and saat='" + Hastaİslemleri.Hour + "' and drkod='"+Hastaİslemleri.DoctorCode+"'";
            MessageBox.Show(Hastaİslemleri.Polyclinic+Hastaİslemleri.DispatchDate.ToShortDateString() + Hastaİslemleri.Hour);
            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void HastaİslemleriDataGrid()
        {
            
            string fileNo = Hastaİslemleri.FileNo;
            query = "Select * From sevk where dosyano='" + fileNo + "' and sevktarihi='" + Hastaİslemleri.PreviousProcessDate.ToShortDateString() + "'and saat='" + Hastaİslemleri.PreviousProcessDate.ToShortTimeString() + "' ";
            cmd = new SqlCommand(query, connection);
            connection.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Hastaİslemleri.Polyclinic = dr["polikinlik"].ToString();
                Hastaİslemleri.QueueNumber = dr["sıra"].ToString();
                Hastaİslemleri.Hour = dr["saat"].ToString();
                Hastaİslemleri.ProcessToDo = dr["yapilanislem"].ToString();
                Hastaİslemleri.DoctorCode = dr["drkod"].ToString();
                Hastaİslemleri.Unit = dr["miktar"].ToString();
                Hastaİslemleri.UnitFee = dr["birimfiyat"].ToString();
                Hastaİslemleri.Discharged = Convert.ToBoolean(dr["taburcu"]);
            }
            
            connection.Close();


        }
        public void HastaİslemleriPrintData()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("PrintTable");
            cmd.CommandType = CommandType.StoredProcedure;
            DataRow dr = dt.NewRow();

            int i = 0;
            string firstquery = "select * from kullanici where kodu='" + Hastaİslemleri.DoctorCode + "'";
            string secondquery = "select * from hasta where dosyano='" + Hastaİslemleri.FileNo + "'";
            string thirdquery = "select * from sevk where polikinlik='" + Hastaİslemleri.Polyclinic + "' and sevktarihi = '"
                + Hastaİslemleri.DispatchDate.ToShortDateString() + "' and saat='" + Hastaİslemleri.Hour + "' and drkod='" + Hastaİslemleri.DoctorCode + "'";
            try
            {
                connection.Open();
                cmd = new SqlCommand(firstquery, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "kullanici");

                cmd = new SqlCommand(secondquery, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "hasta");

                cmd = new SqlCommand(thirdquery, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "sevk");

                adapter.Dispose();
                cmd.Dispose();
                connection.Close();

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    Hastaİslemleri.DoctorCode = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    Hastaİslemleri.DoctorName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                }

                for (i = 0; i <= ds.Tables[1].Rows.Count - 1; i++)
                {
                    Hastaİslemleri.PatientName = ds.Tables[1].Rows[i].ItemArray[2].ToString();
                    Hastaİslemleri.PatientSurname = ds.Tables[1].Rows[i].ItemArray[3].ToString();
                }
                for (i = 0; i <= ds.Tables[2].Rows.Count - 1; i++)
                {
                    Hastaİslemleri.DispatchDate = Convert.ToDateTime(ds.Tables[2].Rows[i].ItemArray[0]);
                    Hastaİslemleri.Polyclinic = ds.Tables[2].Rows[i].ItemArray[2].ToString();
                    Hastaİslemleri.Hour = ds.Tables[2].Rows[i].ItemArray[3].ToString();
                    Hastaİslemleri.ProcessToDo = ds.Tables[2].Rows[i].ItemArray[4].ToString();
                    Hastaİslemleri.Unit = ds.Tables[2].Rows[i].ItemArray[6].ToString();
                    Hastaİslemleri.UnitFee = ds.Tables[2].Rows[i].ItemArray[7].ToString();
                    Hastaİslemleri.QueueNumber = ds.Tables[2].Rows[i].ItemArray[8].ToString();
                    Hastaİslemleri.TotalFee = ds.Tables[2].Rows[i].ItemArray[9].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Bağlantı Açılamadı.\nGirdiğiniz verileri kontrol edin");
            }
        }

        public void SevkInsertData()
        {
            string query = "INSERT INTO sevk(sevktarihi,dosyano,polikinlik,saat,yapilanislem,drkod,miktar,birimfiyat,sıra,toplamtutar,taburcu) VALUES('" + Hastaİslemleri.DispatchDate.ToShortDateString() + "','"
                + Hastaİslemleri.FileNo + "','" + Hastaİslemleri.Polyclinic + "','" + Hastaİslemleri.Hour + "','"
                + Hastaİslemleri.ProcessToDo + "','" + Hastaİslemleri.DoctorCode + "','" + Hastaİslemleri.Unit + "','"
                + Hastaİslemleri.UnitFee + "','" + Hastaİslemleri.QueueNumber + "','" + Taburcu.TotalFee + "','" + Taburcu.DisCharged + "');";
            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();

        }
        public void SekvUpdate()
        {

            query = "UPDATE sevk SET taburcu = '" + Taburcu.DisCharged + "', toplamtutar= '" + Taburcu.TotalFee + "' WHERE sevktarihi = '" + Hastaİslemleri.DispatchDate.ToShortDateString() + "' and saat = '" + Hastaİslemleri.Hour + "';";
            connection.Open();
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public DataTable DosyaBringData()
        {
            DataTable dtHasta = new DataTable();
            if (DosyaBul.PatientName != null && DosyaBul.PatientSurName != null && DosyaBul.Bool == true)
            {
                query = "Select * from hasta where ad='" + DosyaBul.PatientName + "' and soyad='" + DosyaBul.PatientSurName + "'";
            }
            else if (DosyaBul.Bool == false && DosyaBul.PatientSurName != null)
            {
                query = "Select * from hasta where ad='" + DosyaBul.PatientName + "'";
            }
            else if (DosyaBul.Bool == false && DosyaBul.PatientName != null)
            {
                query = "Select * from hasta where ad='" + DosyaBul.PatientName + "'";
            }
            else if (DosyaBul.IdentityNumber !=null)
            {
                query = "Select * from hasta where tckimlikno='" + DosyaBul.IdentityNumber + "'";
            }
            else if (DosyaBul.InstutionRegistryNumber != null)
            {
                query = "Select * from hasta where kurumsicilno='" + DosyaBul.InstutionRegistryNumber + "'";
            }
            else if (DosyaBul.FileNumber != null)
            {
                query = "Select * from hasta where dosyano='" + DosyaBul.FileNumber + "'";
            }
            connection.Open();
            cmd = new SqlCommand(query, connection);
            
            SqlDataReader reader = cmd.ExecuteReader();
            dtHasta.Load(reader);
            connection.Close();
            return dtHasta;
        }
        public DataTable Form1BringData()
        {
            if(Form1.NotDischargePatiens == true)
            {
                query = "Select * from sevk where sevktarihi between '" + Form1.StartDate + "' and '" + Form1.EndDate + "' and taburcu='" + false + "'";
                //query += "select *from sevk where taburcu='"+Form1.NotDischargePatiens+"'";
            }
            else if (Form1.DischargePatiens == true)
            {

                query = "Select * from sevk where sevktarihi between '" + Form1.StartDate + "' and '" + Form1.EndDate + "' and taburcu='"+true+"'";
                //query += "select * from sevk where taburcu='"+Form1.DischargePatiens+"'";

            }
            else if (Form1.AllPatiens == true)
            {
                query = "Select * from sevk where sevktarihi between '" + Form1.StartDate + "' and '" + Form1.EndDate + "'";
            }
            connection.Open();
            cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dtSevkTable = new DataTable();
            dtSevkTable.Load(reader);
            connection.Close();
            return dtSevkTable;
        }      
        public DataTable Form1loadData()
        {
            if (Form1.NotDischargePatiens == true)
            {
                query = "SELECT sevk.dosyano,hasta.ad, hasta.soyad, sevk.sevktarihi,sevk.drkod, kullanici.ad AS DoktorAd, kullanici.soyad AS DoktorSoyad, sevk.polikinlik, sevk.sıra, sevk.saat, sevk.yapilanislem, sevk.miktar, sevk.birimfiyat, sevk.toplamtutar, sevk.taburcu" +
                " FROM hasta INNER JOIN sevk ON hasta.dosyano = sevk.dosyano inner JOIN kullanici on kullanici.kodu = sevk.drkod where sevk.taburcu= '" + false + "' and sevk.sevktarihi between '" + Form1.StartDate + "' and '" + Form1.EndDate + "'";
            }
            else if (Form1.DischargePatiens == true)
            {

                query = "SELECT sevk.dosyano,hasta.ad, hasta.soyad, sevk.sevktarihi,sevk.drkod, kullanici.ad AS DoktorAd, kullanici.soyad AS DoktorSoyad, sevk.polikinlik, sevk.sıra, sevk.saat, sevk.yapilanislem, sevk.miktar, sevk.birimfiyat, sevk.toplamtutar, sevk.taburcu" +
                " FROM hasta INNER JOIN sevk ON hasta.dosyano = sevk.dosyano inner JOIN kullanici on kullanici.kodu = sevk.drkod where sevk.taburcu= '" + true + "' and sevk.sevktarihi between '" + Form1.StartDate + "' and '" + Form1.EndDate + "'";
            }
            else if (Form1.AllPatiens == true)
            {              
                query = "SELECT sevk.dosyano,hasta.ad, hasta.soyad, sevk.sevktarihi,sevk.drkod, kullanici.ad AS DoktorAd, kullanici.soyad AS DoktorSoyad, sevk.polikinlik, sevk.sıra, sevk.saat, sevk.yapilanislem, sevk.miktar, sevk.birimfiyat, sevk.toplamtutar, sevk.taburcu" +
                    " FROM hasta INNER JOIN sevk ON hasta.dosyano = sevk.dosyano inner JOIN kullanici on kullanici.kodu = sevk.drkod where sevk.sevktarihi between '" + Form1.StartDate + "' and '" + Form1.EndDate + "'";
            }    
        
            DataSet ds = new DataSet();
            cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            return dt;              
        }

        public DataTable temporary()
        {

            query = "SELECT kullanici.kodu, kullanici.ad, kullanici.soyad, hasta.ad AS PatientNAme, hasta.soyad AS PatientSurname, sevk.sevktarihi, sevk.polikinlik, sevk.saat, sevk.yapilanislem, sevk.taburcu, sevk.toplamtutar, sevk.birimfiyat, sevk.miktar " +
                "FROM hasta INNER JOIN sevk ON sevk.drkod = kullanici.kodu inner JOIN kullanici where sevk.dosyano='" + Hastaİslemleri.FileNo + "' and sevk.sevktarihi='" + Hastaİslemleri.DispatchDate + "'";
            DataSet ds = new DataSet();
            cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connection.Close();
            return dt; 
        }
        public void userAuthentication()
        {
            query = "SELECT * FROM kullanici where username='" + Login.UserName + "' AND sifre='" + Login.Password + "'";
            sda = new SqlDataAdapter(query, connection);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            connection.Close();
        }

    }
}
