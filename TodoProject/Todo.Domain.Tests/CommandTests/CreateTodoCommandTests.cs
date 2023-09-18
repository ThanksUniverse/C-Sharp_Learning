using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.CommandTests;

[TestClass]
public class CreateTodoCommandTests
{
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo da Tarefa", "Pedro Bertoluchi", DateTime.Now);

    public CreateTodoCommandTests()
    {
        _invalidCommand.Validate();
        _validCommand.Validate();
    }
    [TestMethod]
    public void Dado_um_comano_invalido()
    {
        Assert.AreEqual(_invalidCommand.Valid, false);
    }

    [TestMethod]
    public void Dado_um_comano_valido()
    {
        var command = new CreateTodoCommand("Titulo da Tarefa", "Pedro Bertoluchi", DateTime.Now);
        command.Validate();
        Assert.AreEqual(_validCommand.Valid, true);
    }
}