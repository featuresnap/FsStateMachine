namespace StateMachineFs

type ContinueMessage = |Continue
type Agent<'a> = MailboxProcessor<'a>

type StateMachine () =
    
    member x.Run () = ()
    member x.Continue () = ()

