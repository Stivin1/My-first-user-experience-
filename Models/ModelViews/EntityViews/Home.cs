using OpenSourceEnity.Models.Entities.SystemEntities;
using System.Security.Claims;

namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за пред регистрацию на главной странице 
    //</summary>
    public class Home 
    {
        //<summary>
        //Свойство предоставляющее пользователя
        //</summary>
        public User User { get; set; }

        //<summary>
        //Свойство предоставляющее участника
        //</summary>
        public Participant Participant { get; set; }

        //<summary>
        //Свойство предоставляющее страну
        //</summary>
        public Country Country { get; set; }

        //<summary>
        //Свойство предоставляющее пола
        //</summary>
        public Pol Pol { get; set; }

        //<summary>
        //Свойство предоставляющее пола
        //</summary>
        public Claim Claim { get; set; }
    }
}
