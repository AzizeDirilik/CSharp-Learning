using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }

    }

}
