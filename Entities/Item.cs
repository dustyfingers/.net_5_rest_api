namespace Catalog.Entities 
{

    // classes are cool...but
    // public class Item 
    // {



    // }

    // record types can be used for immutable objects!
    public record Item 
    {

        //  Guid is init only (vs get; set; )
        public Guid Id { get; init; }

        public string Name { get; init; } = "";

        public decimal Price { get; init; }

        public DateTimeOffset CreatedDate { get; init; }

    }

}