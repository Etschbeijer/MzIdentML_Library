namespace MzIdentMLDataBase

module XML_Insertstatement =

    open BioFSharp.IO
    open FSharp.Care.IO
    open InsertStatements.ManipulateDataContextAndDB
    open InsertStatements.ObjectHandlers

    module initializeStandardDB =
        open DataContext.DataContext
        
        ///Define reader for OboFile
        let fromFileObo (filePath : string) =
            FileIO.readFile filePath
            |> Obo.parseOboTerms

        let fromPsiMS =
            fromFileObo (fileDir + "\Ontologies\Psi-MS.txt")

        let fromPride =
            fromFileObo (fileDir + "\Ontologies\Pride.txt")

        let fromUniMod =
            fromFileObo (fileDir + "\Ontologies\Unimod.txt")

        let fromUnit_Ontology =
            fromFileObo (fileDir + "\Ontologies\Unit_Ontology.txt")

        let initStandardDB (context : MzIdentMLContext) =
            let terms_PsiMS =
                fromPsiMS
                |> Seq.map (fun termItem -> TermHandler.init(termItem.Id, termItem.Name))
            let psims = OntologyHandler.init ("Psi-MS", terms_PsiMS)
            OntologyHandler.addToContext context psims |> ignore

            let terms_Pride =
                fromPsiMS
                |> Seq.map (fun termItem -> TermHandler.init(termItem.Id, termItem.Name))
            let psims = OntologyHandler.init ("Pride", terms_Pride)
            OntologyHandler.addToContext context psims |> ignore

            let terms_Unimod =
                fromPsiMS
                |> Seq.map (fun termItem -> TermHandler.init(termItem.Id, termItem.Name))
            let psims = OntologyHandler.init ("Unimod", terms_Unimod)
            OntologyHandler.addToContext context psims |> ignore

            let terms_Unit_Ontology =
                fromPsiMS
                |> Seq.map (fun termItem -> TermHandler.init(termItem.Id, termItem.Name))
            let psims = OntologyHandler.init ("Unit_Ontology", terms_Unit_Ontology)
            OntologyHandler.addToContext context psims |> ignore

            context.Database.EnsureCreated() |> ignore
            context.SaveChanges()
