namespace BookStore.API.Contracts
{
    public record BooksResponse(
        Guid Id,
        string Title,
        string Description,
        decimal Price);

    public record BookRequest(
        string Title,
        string Description,
        decimal Price);
}
