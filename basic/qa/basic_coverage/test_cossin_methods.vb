' This file is part of the LibreOffice project.
'
' This Source Code Form is subject to the terms of the Mozilla Public
' License, v. 2.0. If a copy of the MPL was not distributed with this
' file, You can obtain one at http://mozilla.org/MPL/2.0/.
'

Function doUnitTest as Integer
    ' COS SIN
    If ( Abs(Cos(PI/3) - Sin(PI/6)) > 1E-6 ) Then
        doUnitTest = 0
    Else
        doUnitTest = 1
    End If
End Function
