Namespace My
    Partial Class MyApplication
        ''' <summary>
        ''' Are we running on the author's machine.
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property IsAuthorMachineRunningUnderDebugger() As Boolean
            Get
                Return IsAuthor AndAlso Debugger.IsAttached
            End Get
        End Property
        ''' <summary>
        ''' Change from Karens to your user name to activate 
        ''' pre-defined date ranges in the date range demo and
        ''' pre-checking items in the string in demo.
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property IsAuthor() As Boolean
            Get
                Return Environment.UserName = "Karens"
            End Get
        End Property
    End Class
End Namespace