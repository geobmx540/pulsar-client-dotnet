﻿namespace Pulsar.Client.Api
open System
open System.Runtime.InteropServices
open Pulsar.Client.Auth

[<AbstractClass; Sealed>]
type AuthenticationFactoryOAuth2 =

    static member ClientCredentials (issuerUrl : Uri, 
                                     audience: string, 
                                     clientId: string, 
                                     clientSecret: string,
                                     [<Optional; DefaultParameterValue(null:string)>] scope) =
        DefaultImplementation.newAuthenticationOauth2 (issuerUrl, audience, clientId, clientSecret, scope)
        :> Authentication