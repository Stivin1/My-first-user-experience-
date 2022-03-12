using System;

namespace OpenSourceEnity.Models.Entities.EntityController.ExtensionAgeMethods
{
    //<summary>
    //Статический класс по работе с датами рождения
    //</summary>
    public static class ExtensionAge
    {
        //<summary>
        //Метод по работе с датой рождения
        ///<param name="DateAge">Ссылка на строку даты рождения</param>
        //</summary>
        public static int UserAge(this string DateAge)
        {
            DateTime dateTime;
            DateTime dateTime1 = DateTime.Now;

            DateTime.TryParse(DateAge, out dateTime);

            int Age = dateTime1.Year - dateTime.Year;

            if (dateTime1.Month < dateTime.Month || (dateTime1.Month == dateTime.Month && dateTime1.Day < dateTime.Day)) Age--;

            return Age;
        }
    }
}
