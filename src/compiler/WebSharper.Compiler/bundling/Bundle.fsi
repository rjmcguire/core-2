// $begin{copyright}
//
// This file is part of WebSharper
//
// Copyright (c) 2008-2015 IntelliFactory
//
// Licensed under the Apache License, Version 2.0 (the "License"); you
// may not use this file except in compliance with the License.  You may
// obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
// implied.  See the License for the specific language governing
// permissions and limitations under the License.
//
// $end{copyright}

namespace WebSharper.Compiler

/// Experimental API for bundling WebSharper file sets into application packages.
[<Sealed>]
type Bundle =
    member CSS : Content
    member HtmlHeaders : Content
    member JavaScript : Content
    member JavaScriptHeaders : Content
    member MinifiedJavaScript : Content
    member TypeScript : Content
    member ContentFiles : seq<EmbeddedFile>
    member WithAssembly : assemblyFile: string -> Bundle
    member WithAssembly : assembly: Assembly -> Bundle
    member WithAppConfig : string -> Bundle
    member WithDefaultReferences : unit -> Bundle
    member WithTransitiveReferences : unit -> Bundle
    static member Empty : Bundle
    static member Create : unit -> Bundle
