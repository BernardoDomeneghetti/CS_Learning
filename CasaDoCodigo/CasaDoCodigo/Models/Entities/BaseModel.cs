namespace CasaDoCodigo.Models.Entities
{
    public abstract class BaseModel
    {
        
        public int Id { get; set; }

        public abstract void SetKey();
    }
}
