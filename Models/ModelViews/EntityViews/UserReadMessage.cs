
namespace OpenSourceEnity.Models.ModelViews.EntityViews
{
    //<summary>
    //Модель отвечающая за чтение сообщения
    //</summary>
    public class UserReadMessage
    {
        //<summary>
        //Идентификатор прользователя
        //</summary>
        public string UserId { get; set; }

        //<summary>
        //Идентификатор получателя прользователя
        //</summary>
        public string UserRecipientId { get; set; }

        //<summary>
        //Имя прользователя кто направил сообщение
        //</summary>
        public string UserDonorName { get; set; }

        //<summary>
        //Имя прользователя кому направлено сообщение
        //</summary>
        public string UserRecipienName { get; set; }

        //<summary>
        //Текст сообщения
        //</summary>
        public string Text { get; set; }
    }
}
