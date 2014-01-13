namespace StateMachineFsTests

[<NUnit.Framework.TestFixture>]
module StateMachineTests = 
    open NUnit
    open NUnit.Framework
    open FsUnit
    open StateMachineFs

    [<Test>]
    let ``it runs`` () =
        let machine = new StateMachine()
        machine.Run()
        Assert.Pass()

    [<Test>]
    let ``it can be told to continue`` () =
        let machine = new StateMachine()
        machine.Run()
        machine.Continue()
        Assert.Pass()


