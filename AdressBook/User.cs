namespace AdressBook
{
    class User
    {
        //public string FullName { get { return string.Format("{0} {1}",FirstName,LastName); } }
        public string name { get; set; }
        public string adress { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string email { get; set; }


        public User(string info)
        {
            var infoArray = info.Split(',');
            if(infoArray.Length == 6)
            {
                name = infoArray[0].Trim();
                adress = infoArray[1].Trim();
                zip = infoArray[2].Trim();
                city = infoArray[3].Trim();
                phone = infoArray[4].Trim();
                email = infoArray[5].Trim();
            }
        }
        public User()
        {
            name = "New Contact";
            adress = "";
            zip = "";
            city = "";
            phone = "";
            email = "";
        }

        public string Serialize()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}", name, adress, zip, city, phone, email);
        }

        public void UpdateUser(string userName, string userAdress, string userZip, string userCity, string userPhone, string userEmail)
        {
            name = userName;
            adress = userAdress;
            zip = userZip;
            city = userCity;
            phone = userPhone;
            email = userEmail;
            //DataManager.SaveUser(this);
        }
    }
}
