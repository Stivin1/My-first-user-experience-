

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за создание роли
    //</summary>
    public class RoleCreate
    {
        //<summary>
        //Идентификатор пользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Поле наименование роли
        //</summary>
        public string RoleName { get; set; }
    }
}
