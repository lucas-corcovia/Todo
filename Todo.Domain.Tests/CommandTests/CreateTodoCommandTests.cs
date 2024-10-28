using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests;

[TestClass]
public class CreateTodoCommandTests
{
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", DateTime.Now, "");
    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo da tarefa", DateTime.Now, "Stephen Curry");

    public CreateTodoCommandTests()
    {
        _invalidCommand.Validate();
        _validCommand.Validate();
    }

    [TestMethod]
    public void Dado_um_commando_invalido()
    {       
        Assert.AreEqual(_invalidCommand.Valid, false);
    }

    [TestMethod]
    public void Dado_um_commando_valido()
    {
        Assert.AreEqual(_validCommand.Valid, true);
    }
}