var mock = new Mock<IService>();
mock.Setup(x => x.Get()).Returns("Mocked");

Console.WriteLine(mock.Object.Get());
