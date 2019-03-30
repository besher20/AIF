using System;
namespace ChefBox.Model.Base
{

    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsValid { get; set; } = true;
    }
}
