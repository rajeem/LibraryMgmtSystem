using LibraryMgmtSystem.Domain.Entities;
using LibraryMgmtSystem.Infrastructure;

namespace LibraryMgmtSystem.IntegrationTest
{
    public class FlatFileRepositoryTests
    {
        [Fact]
        public void AddRecordToRepository_SuccessfullyAddsRecord()
        {
            if (File.Exists("Book.dat")) File.Delete("Book.dat");

            var repo = new FlatFileRepository();
            
            repo.Add(new Book { Id = "f3cfc4f8-c174-447d-8e2c-b674f4c81c4d", Author = "F. Scott Fitzgerald", Title = "The Great Gatsby", Isbn = "978-0743273565" });

            var book = repo.Get<Book>("f3cfc4f8-c174-447d-8e2c-b674f4c81c4d");

            Assert.NotNull(book);
            Assert.Equal("f3cfc4f8-c174-447d-8e2c-b674f4c81c4d", book.Id);
            Assert.Equal("F. Scott Fitzgerald", book.Author);
            Assert.Equal("The Great Gatsby", book.Title);
            Assert.Equal("978-0743273565", book.Isbn);
        }

        [Fact]
        public void UpdateRecordToRepository_SuccessfullyUpdatesRecord()
        {
            if (File.Exists("Book.dat")) File.Delete("Book.dat");

            var repo = new FlatFileRepository();

            repo.Add(new Book { Id = "f3cfc4f8-c174-447d-8e2c-b674f4c81c4d", Author = "J.K. Rowling", Title = "Harry Potter and the Sorcerer's Stone", Isbn = "978-0590353427" });
            repo.Update(new Book { Id = "f3cfc4f8-c174-447d-8e2c-b674f4c81c4d", Author = "F. Scott Fitzgerald", Title = "The Great Gatsby", Isbn = "978-0743273565" });

            var book = repo.Get<Book>("f3cfc4f8-c174-447d-8e2c-b674f4c81c4d");

            Assert.NotNull(book);
            Assert.Equal("f3cfc4f8-c174-447d-8e2c-b674f4c81c4d", book.Id);
            Assert.Equal("F. Scott Fitzgerald", book.Author);
            Assert.Equal("The Great Gatsby", book.Title);
            Assert.Equal("978-0743273565", book.Isbn);
        }
    }
}