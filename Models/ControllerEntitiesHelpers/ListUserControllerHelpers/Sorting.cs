

namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListUserControllerHelpers
{
    //<summary>
    //Класс перечисления сортировки
    //</summary>
    public class Sorting
    {
        //<summary>
        //Список доступных сортировок
        //</summary>
        public enum Sort
        {
            NameAsc,
            NameDesc,
            MiddleNameAsc,
            MiddleNameDesc,
            LastNameAsc,
            LastNameDesc,
        }

        //<summary>
        //Сортировка по умолчанию
        //</summary>
        public Sort Default;

        //<summary>
        //Сортировка по имени
        //</summary>
        public Sort Name;

        //<summary>
        //Сортировка по фамилии
        //</summary>
        public Sort MiddleName;

        //<summary>
        //Сортировка по отчеству
        //</summary>
        public Sort LastName;
        
    }
}
