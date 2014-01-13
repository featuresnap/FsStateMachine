namespace StateMachineFs

type ContinueMessage = |Continue
type Agent<'a> = MailboxProcessor<'a>

type StateMachine () =

    let machine = new Agent<ContinueMessage>(fun agent ->
        let rec loop count = 
            async {
                let! msg = agent.Receive()
                printfn "Received call number %d" count
                return! loop (count + 1) }
        loop 0)

    member x.Run () = machine.Start()
    member x.Continue () = machine.Post(Continue)

