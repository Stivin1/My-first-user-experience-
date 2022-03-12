
namespace OpenSourceEnity.Models.ControllerEntitiesHelpers.ListReceivMessageControllerHelpers
{
    //<summary>
    //Класс перечисления сортировки
    //</summary>
    public class Sorting
    {
        //<summary>
        //Список доступных сортировок
        //</summary>
        public enum ReceivSort
        {
            NameAsc,
            NameDesc,
            MiddleNameAsc,
            MiddleNameDesc,
            LastNameAsc,
            LastNameDesc,
            UserNameAsc,
            UserNameDesc,
        }

        //<summary>
        //Сортировка по умолчанию
        //</summary>
        public ReceivSort Default { get; set; }

        //<summary>
        //Сортировка по имени
        //</summary>
        public ReceivSort Name { get; set; }

        //<summary>
        //Сортировка по фамилии
        //</summary>
        public ReceivSort MiddleName { get; set; }

        //<summary>
        //Сортировка по отчеству
        //</summary>
        public ReceivSort LastName { get; set; }

        //<summary>
        //Сортировка по имени пользователя
        //</summary>
        public ReceivSort UserName { get; set; }
    }
}
