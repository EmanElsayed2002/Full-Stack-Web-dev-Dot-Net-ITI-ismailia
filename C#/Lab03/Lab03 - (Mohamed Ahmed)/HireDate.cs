namespace Lab3
{
    internal class HireDate
    {
        int day;
        int month;
        int year;


        public void SetDay(int _day)
        {
            day = _day;
        }

        public int GetDay()
        {
            return day;
        }
        public void SetMonth(int _month)
        {
            month = _month;
        }
        public int GetMonth()
        {
            return month;
        }
        public void Setyear(int _year)
        {
            year = _year;
        }
        public int GetYear()
        {
            return year;
        }

        public HireDate()
        {
            
        }
        public HireDate(int _day, int _month, int _year)     
        {
            day = _day;
            month = _month;
            year = _year;
        }

        public string Print()
        {
            return $"{day} : {month} : {year}";
        }
    }
}