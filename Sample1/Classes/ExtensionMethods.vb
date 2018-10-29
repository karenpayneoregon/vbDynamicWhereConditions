Namespace Classes
    Public Module ExtensionMethods
        ''' <summary>
        ''' Determine if date range is valid
        ''' </summary>
        ''' <param name="pStartRange"></param>
        ''' <param name="pEndRange"></param>
        ''' <returns></returns>
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function IsValidRange(pStartRange As Date, pEndRange As Date) As Boolean
            Return Not (pStartRange > pEndRange OrElse pEndRange < pStartRange OrElse pStartRange = pEndRange)
        End Function
    End Module
End Namespace