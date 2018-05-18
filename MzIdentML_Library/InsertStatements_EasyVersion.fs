namespace InserStatements_Abstraction_EasyVersion

open Entities_DBContext_EasyVersion


open EntityTypes
open DataContext



open System
//open System.ComponentModel.DataAnnotations
//open System.ComponentModel.DataAnnotations.Schema
open Microsoft.EntityFrameworkCore
open System.Collections.Generic
//open FSharp.Care.IO
//open BioFSharp.IO



module SubFunctions =

    //ObjectHandlers

    let convertOptionToList (optionOfType : seq<'a> option) =
        match optionOfType with
        | Some x -> x |> List
        | None -> null

    let addToList (typeCollection : List<'a>) (optionOfType : 'a) =
        match typeCollection with
        | null -> 
            let tmp = new List<'a>()
            tmp.Add optionOfType
            tmp
        | _ -> 
            typeCollection.Add optionOfType
            typeCollection

    let addCollectionToList (typeCollection : List<'a>) (optionOfType : seq<'a>) =
        match typeCollection with
        | null -> 
            let tmp = new List<'a>()
            tmp.AddRange optionOfType
            tmp
        | _ -> 
            typeCollection.AddRange optionOfType
            typeCollection

    let addOptionToList (typeCollection : List<'a>) (optionOfType : 'a option) =
        match optionOfType with
        | Some x -> addToList typeCollection x
        | None -> typeCollection

    let addOptionCollectionToList (inputCollection : List<'a>) (input : seq<'a> option) =
        match input with
        |Some x -> addCollectionToList inputCollection x
        |None -> inputCollection
  
module ManipulateDataContextAndDB =

    let addToContextWithExceptionCheck (context : MzIdentMLContext) (item : 'a) =
        try
            context.Add(item) |> ignore
            true
        with
            | :? System.InvalidOperationException as text ->
                printfn "%s" text.Message
                false
            | _ -> 
                false

    let insertWithExceptionCheck (context : MzIdentMLContext) =
        try
            context.SaveChanges()
            |> (fun i -> printfn "Added %i elements to the DB" i)
            true
        with
            | :? Microsoft.EntityFrameworkCore.DbUpdateException as text ->
                    printfn "%s" text.Message
                    false
            |_ ->
                false

    let fileDir = __SOURCE_DIRECTORY__
    let standardDBPathSQLite = fileDir + "\Ontologies_Terms\Test.db"

    let configureSQLiteContextMzIdentML path = 
        let optionsBuilder = new DbContextOptionsBuilder<MzIdentMLContext>()
        optionsBuilder.UseSqlite(@"Data Source=" + path) |> ignore
        new MzIdentMLContext(optionsBuilder.Options)

module ObjectHandlers =

    open ManipulateDataContextAndDB
    open SubFunctions

    type TermHandler =
           static member init
                (
                    id        : string,
                    ?name     : string,
                    ?ontology : Ontology  
                ) =
                let name'      = defaultArg name null
                let ontology'  = defaultArg ontology Unchecked.defaultof<Ontology>
                {
                    ID         = id;
                    Name       = name';
                    Ontology   = ontology';
                    RowVersion = DateTime.Now
                }

           static member addName
                (term:Term) (name:string) =
                term.Name <- name
                term

           static member addOntology
                (term:Term) (ontology:Ontology) =
                term.Ontology <- ontology
                term

            static member addToContext (context:MzIdentMLContext) (item:Term) =
                    addToContextWithExceptionCheck context item

            static member addAndInsert (context:MzIdentMLContext) (item:Term) =
                    (addToContextWithExceptionCheck context item) |> ignore
                    insertWithExceptionCheck context
        
    type OntologyHandler =
           static member init
                (
                    id     : string,
                    ?terms : seq<Term>
                ) =
                let terms'     = convertOptionToList terms
                {
                    ID         = id;
                    Terms      = terms';
                    RowVersion = DateTime.Now
                }

            static member addTerm
                (ontology:Ontology) (term:Term) =
                let result = ontology.Terms <- addToList ontology.Terms term
                ontology


            static member addTerms
                (ontology:Ontology) (terms:seq<Term>) =
                let result = ontology.Terms <- addCollectionToList ontology.Terms terms
                ontology

            static member addToContext (context:MzIdentMLContext) (item:Ontology) =
                addToContextWithExceptionCheck context item

            static member insertIntoDB (context:MzIdentMLContext) (item:Ontology) =
                    (addToContextWithExceptionCheck context item) |> ignore
                    insertWithExceptionCheck context
            
    type CVParamHandler =

           static member init
                (
                    name      : string,
                    term      : Term,
                    ?id       : int,
                    ?value    : string,
                    ?unit     : Term,
                    ?unitName : string
                ) =
                let id'       = defaultArg id 0
                let value'    = defaultArg value null
                let unit'     = defaultArg unit Unchecked.defaultof<Term>
                let unitName' = defaultArg unitName null
                {
                    ID         = id';
                    Name       = name;
                    Value      = value';
                    Term       = term;
                    Unit       = unit';
                    UnitName   = unitName';
                    RowVersion = DateTime.Now
                }
           static member addValue
                (cvParam:CVParam) (value:string) =
                cvParam.Value <- value
                cvParam

           static member addUnit
                (cvParam:CVParam) (unit:Term) =
                cvParam.Unit <- unit
                cvParam

           static member addUnitName
                (cvParam:CVParam) (unitName:string) =
                cvParam.UnitName <- unitName
                cvParam

            static member addToContext (context:MzIdentMLContext) (item:CVParam) =
                    (addToContextWithExceptionCheck context item)

            static member insert (context:MzIdentMLContext) (item:CVParam) =
                    (addToContextWithExceptionCheck context item) |> ignore
                    insertWithExceptionCheck context

    type OrganizationHandler =
           static member init
                (
                    ?id      : int,
                    ?name    : string,
                    ?details : seq<CVParam>,
                    ?parent  : string
                ) =
                let id'      = defaultArg id 0
                let name'    = defaultArg name null
                let details' = convertOptionToList details
                let parent'  = defaultArg parent null
                {
                    Organization.ID         = id';
                    Organization.Name       = name';
                    Organization.Details    = details';
                    Organization.Parent     = parent';
                    Organization.RowVersion = DateTime.Now
                }

           static member addName
                (organization:Organization) (name:string) =
                organization.Name <- name

           static member addParent
                (organization:Organization) (parent:string) =
                organization.Parent <- parent

           static member addDetail
                (organization:Organization) (detail:CVParam) =
                let result = organization.Details <- addToList organization.Details detail
                organization

           static member addDetails
                (organization:Organization) (details:seq<CVParam>) =
                let result = organization.Details <- addCollectionToList organization.Details details
                organization

           static member addToContext (context:MzIdentMLContext) (item:Organization) =
                (addToContextWithExceptionCheck context item)

           static member insert (context:MzIdentMLContext) (item:Organization) =
                (addToContextWithExceptionCheck context item) |> ignore
                insertWithExceptionCheck context

    type PersonHandler =
           static member init
                (
                    ?id             : int,
                    ?name           : string,
                    ?firstName      : string,
                    ?midInitials    : string,
                    ?lastName       : string,
                    ?contactDetails : seq<CVParam>,
                    ?organizations  : seq<Organization> 
                ) =
                let id'          = defaultArg id 0
                let name'        = defaultArg name null
                let firstName'   = defaultArg firstName null
                let midInitials' = defaultArg midInitials null
                let lastName'    = defaultArg lastName null
                {
                    Person.ID            = id';
                    Person.Name          = name';
                    Person.FirstName     = firstName';
                    Person.MidInitials   = midInitials';
                    Person.LastName      = lastName';
                    Person.Details       = convertOptionToList contactDetails;
                    Person.Organizations = convertOptionToList organizations;
                    Person.RowVersion    = DateTime.Now
                }

           static member addName
                (person:Person) (name:string) =
                person.Name <- name
                person
           static member addFirstName
                (person:Person) (firstName:string) =
                person.FirstName <- firstName
                person
           static member addMidInitials
                (person:Person) (midInitials:string) =
                person.MidInitials <- midInitials
                person
           static member addLastName
                (person:Person) (lastName:string) =
                person.LastName <- lastName
                person
           static member addDetail (person:Person) (detail:CVParam) =
                let result = person.Details <- addToList person.Details detail
                person

           static member addDetails
                (person:Person) (details:seq<CVParam>) =
                let result = person.Details <- addCollectionToList person.Details details
                person

           static member addOrganization
                (person:Person) (organization:Organization) =
                let result = person.Organizations <- addToList person.Organizations organization
                person

           static member addOrganizations
                (person:Person) (organizations:seq<Organization>) =
                let result = person.Organizations <- addCollectionToList person.Organizations organizations
                person

            static member addToContext (context:MzIdentMLContext) (item:Person) =
                    (addToContextWithExceptionCheck context item)

            static member insert (context:MzIdentMLContext) (item:Person) =
                    (addToContextWithExceptionCheck context item) |> ignore
                    insertWithExceptionCheck context

    type ContactRoleHandler =
           static member init
                (   
                    person : Person, 
                    role   : CVParam,
                    ?id    : int
                ) =
                let id' = defaultArg id 0
                {
                     ContactRole.ID         = id'
                     ContactRole.Person     = person
                     ContactRole.Role       = role
                     ContactRole.RowVersion = DateTime.Now.Date
                }

    type AnalysisSoftwareHandler =
           static member init
                (
                    softwareName       : CVParam,
                    ?id                : int,
                    ?name              : string,
                    ?uri               : string,
                    ?version           : string,
                    ?customizations    : string,
                    ?softwareDeveloper : ContactRole
                ) =
                let id'             = defaultArg id 0
                let name'           = defaultArg name null
                let uri'            = defaultArg uri null
                let version'        = defaultArg version null
                let customizations' = defaultArg customizations null
                let contactRole'    = defaultArg softwareDeveloper Unchecked.defaultof<ContactRole>
                {
                    AnalysisSoftware.ID             = id';
                    AnalysisSoftware.Name           = name';
                    AnalysisSoftware.URI            = uri';
                    AnalysisSoftware.Version        = version';
                    AnalysisSoftware.Customizations = customizations';
                    AnalysisSoftware.ContactRole    = contactRole';
                    AnalysisSoftware.SoftwareName   = softwareName;
                    AnalysisSoftware.RowVersion     = DateTime.Now
                }
           static member addName
                (analysisSoftware:AnalysisSoftware) (name:string) =
                analysisSoftware.Name <- name
                analysisSoftware
           static member addURI
                (analysisSoftware:AnalysisSoftware) (uri:string) =
                analysisSoftware.URI <- uri
                analysisSoftware
           static member addVersion
                (analysisSoftware:AnalysisSoftware) (version:string) =
                analysisSoftware.Version <- version
                analysisSoftware
           static member addCustomization
                (analysisSoftware:AnalysisSoftware) (customizations:string) =
                analysisSoftware.Customizations <- customizations
                analysisSoftware
           static member addCustomizations
                (analysisSoftware:AnalysisSoftware) (contactRole:ContactRole) =
                analysisSoftware.ContactRole <- contactRole
                analysisSoftware
            static member addToContext (context:MzIdentMLContext) (item:AnalysisSoftware) =
                    (addToContextWithExceptionCheck context item)

            static member insert (context:MzIdentMLContext) (item:AnalysisSoftware) =
                    (addToContextWithExceptionCheck context item) |> ignore
                    insertWithExceptionCheck context

    type SubSampleHandler =
           static member init
                (
                    ?id                  : int,
                    ?subSampleID        : string
                ) =
                let id'          = defaultArg id 0
                let subSampleID' = defaultArg subSampleID null
                {
                    SubSample.ID          = id';
                    SubSample.SubSampleID = subSampleID';
                    SubSample.RowVersion  = DateTime.Now
                }

           static member addName
                (subSample:SubSample) (subSampleID:string) =
                subSample.SubSampleID <- subSampleID

           static member addToContext (context:MzIdentMLContext) (item:SubSample) =
                (addToContextWithExceptionCheck context item)

           static member insert (context:MzIdentMLContext) (item:SubSample) =
                (addToContextWithExceptionCheck context item) |> ignore
                insertWithExceptionCheck context

    type SampleHandler =
           static member init
                (
                    ?id            : int,
                    ?name         : string,
                    ?contactRoles : seq<ContactRole>,
                    ?subSamples   : seq<SubSample>,
                    ?details      : seq<CVParam>
                ) =
                let id'           = defaultArg id 0
                let name'         = defaultArg name null
                let contactRoles' = convertOptionToList contactRoles
                let subSamples'   = convertOptionToList subSamples
                let details'      = convertOptionToList details
                {
                    Sample.ID           = id'
                    Sample.Name         = name'
                    Sample.ContactRoles = contactRoles'
                    Sample.SubSamples   = subSamples'
                    Sample.Details      = details'
                    Sample.RowVersion   = DateTime.Now
                }

           static member addName
                (subSample:SubSample) (subSampleID:string) =
                subSample.SubSampleID <- subSampleID

           static member addContactRoles
                (sample:Sample) (contactRoles:seq<ContactRole>) =
                let result = sample.ContactRoles <- addCollectionToList sample.ContactRoles contactRoles
                sample

           static member addSubSamples
                (sample:Sample) (subSamples:seq<SubSample>) =
                let result = sample.SubSamples <- addCollectionToList sample.SubSamples subSamples
                sample

           static member addDetails
                (sample:Sample) (details:seq<CVParam>) =
                let result = sample.Details <- addCollectionToList sample.Details details
                sample

           static member addToContext (context:MzIdentMLContext) (item:Sample) =
                (addToContextWithExceptionCheck context item)

           static member insert (context:MzIdentMLContext) (item:Sample) =
                (addToContextWithExceptionCheck context item) |> ignore
                insertWithExceptionCheck context

    type ModificationHandler =
           static member init
                (
                    details                : seq<CVParam>,
                    ?id                    : int,
                    ?residues              : string,
                    ?location              : int,
                    ?monoIsotopicMassDelta : float,
                    ?avgMassDelta          : float
                ) =
                let id'               = defaultArg id 0
                let residues'         = defaultArg residues null
                let location'         = defaultArg location Unchecked.defaultof<int>
                let monoIsotopicMassDelta' = defaultArg monoIsotopicMassDelta Unchecked.defaultof<float>
                let avgMassDelta' = defaultArg avgMassDelta Unchecked.defaultof<float>
                {
                    Modification.ID                    = id'
                    Modification.Details               = details |> List
                    Modification.Residues              = residues'
                    Modification.Location              = location'
                    Modification.MonoIsotopicMassDelta = monoIsotopicMassDelta'
                    Modification.AvgMassDelta          = avgMassDelta'
                    Modification.RowVersion            = DateTime.Now
                }

           static member addResidues
                (modification:Modification) (residues:string) =
                modification.Residues <- residues

           static member addLocation
                (modification:Modification) (location:int) =
                modification.Location <- location

           static member addMonoIsotopicMassDelta
                (modification:Modification) (monoIsotopicMassDelta:float) =
                modification.MonoIsotopicMassDelta <- monoIsotopicMassDelta

           static member addAvgMassDelta
                (modification:Modification) (avgMassDelta:float) =
                modification.AvgMassDelta <- avgMassDelta

           static member addToContext (context:MzIdentMLContext) (item:Modification) =
                (addToContextWithExceptionCheck context item)

           static member insert (context:MzIdentMLContext) (item:Modification) =
                (addToContextWithExceptionCheck context item) |> ignore
                insertWithExceptionCheck context

    type SubstitutionModificationHandler =
           static member init
                (
                    originalResidue        : string,
                    replacementResidue     : string,
                    ?id                    : int,
                    ?location              : int,
                    ?monoIsotopicMassDelta : float,
                    ?avgMassDelta          : float
                ) =
                let id'                    = defaultArg id 0
                let location'              = defaultArg location Unchecked.defaultof<int>
                let monoIsotopicMassDelta' = defaultArg monoIsotopicMassDelta Unchecked.defaultof<float>
                let avgMassDelta'          = defaultArg avgMassDelta Unchecked.defaultof<float>
                {
                    SubstitutionModification.ID                    = id'
                    SubstitutionModification.OriginalResidue       = originalResidue
                    SubstitutionModification.ReplacementResidue    = replacementResidue
                    SubstitutionModification.Location              = location'
                    SubstitutionModification.MonoIsotopicMassDelta = monoIsotopicMassDelta'
                    SubstitutionModification.AvgMassDelta          = avgMassDelta'
                    SubstitutionModification.RowVersion            = DateTime.Now
                }

           static member addLocation
                (substitutionModification:SubstitutionModification) (location:int) =
                substitutionModification.Location <- location

           static member addMonoIsotopicMassDelta
                (substitutionModification:SubstitutionModification) (monoIsotopicMassDelta:float) =
                substitutionModification.MonoIsotopicMassDelta <- monoIsotopicMassDelta

           static member addAvgMassDelta
                (substitutionModification:SubstitutionModification) (avgMassDelta:float) =
                substitutionModification.AvgMassDelta <- avgMassDelta

           static member addToContext (context:MzIdentMLContext) (item:SubstitutionModification) =
                (addToContextWithExceptionCheck context item)

           static member insert (context:MzIdentMLContext) (item:SubstitutionModification) =
                (addToContextWithExceptionCheck context item) |> ignore
                insertWithExceptionCheck context

    type PeptideHandler =
           static member init
                (
                    peptideSequence            : string,
                    ?id                        : int,
                    ?name                      : string,                    
                    ?modifications             : seq<Modification>,
                    ?substitutionModifications : seq<SubstitutionModification>,
                    ?details                   : seq<CVParam>
                ) =
                let id'                        = defaultArg id 0
                let name'                      = defaultArg name null
                let modifications'             = convertOptionToList modifications
                let substitutionModifications' = convertOptionToList substitutionModifications
                let details'                   = convertOptionToList details
                {
                    Peptide.ID                        = id'
                    Peptide.Name                      = name'
                    Peptide.PeptideSequence           = peptideSequence
                    Peptide.Modifications             = modifications'
                    Peptide.SubstitutionModifications = substitutionModifications'
                    Peptide.Details                   = details'
                    Peptide.RowVersion                = DateTime.Now
                }

           static member addName
                (peptide:Peptide) (name:string) =
                peptide.Name <- name

           static member addModifications
                (peptide:Peptide) (modifications:seq<Modification>) =
                let result = peptide.Modifications <- addCollectionToList peptide.Modifications modifications
                peptide

           static member addSubstitutionModifications
                (peptide:Peptide) (substitutionModifications:seq<SubstitutionModification>) =
                let result = peptide.SubstitutionModifications <- addCollectionToList peptide.SubstitutionModifications substitutionModifications
                peptide

           static member addDetails
                (peptide:Peptide) (details:seq<CVParam>) =
                let result = peptide.Details <- addCollectionToList peptide.Details details
                peptide

           static member addToContext (context:MzIdentMLContext) (item:Peptide) =
                (addToContextWithExceptionCheck context item)

           static member insert (context:MzIdentMLContext) (item:Peptide) =
                (addToContextWithExceptionCheck context item) |> ignore
                insertWithExceptionCheck context

    type TranslationTableHandler =
           static member init
                (
                    ?id       : int,
                    ?name    : string,
                    ?details : seq<CVParam>
                ) =
                let name'                      = defaultArg name null
                let details'                   = convertOptionToList details
                {
                    TranslationTable.ID          = 0
                    TranslationTable.Name        = name'
                    TranslationTable.Details     = details'
                    TranslationTable.RowVersion  = DateTime.Now
                }

           static member addName
                (translationTable:TranslationTable) (name:string) =
                translationTable.Name <- name

           static member addDetails
                (translationTable:TranslationTable) (details:seq<CVParam>) =
                let result = translationTable.Details <- addCollectionToList translationTable.Details details
                translationTable

           static member addToContext (context:MzIdentMLContext) (item:TranslationTable) =
                (addToContextWithExceptionCheck context item)

           static member insert (context:MzIdentMLContext) (item:TranslationTable) =
                (addToContextWithExceptionCheck context item) |> ignore
                insertWithExceptionCheck context

    type MeasureHandler =
           static member init
                (
                    details  : seq<CVParam>,
                    ?id      : int,
                    ?name    : string 
                ) =
                let id'   = defaultArg id 0
                let name' = defaultArg name null
                {
                    TranslationTable.ID          = id'
                    TranslationTable.Name        = name'
                    TranslationTable.Details     = details |> List
                    TranslationTable.RowVersion  = DateTime.Now
                }

           static member addName
                (measure:Measure) (name:string) =
                measure.Name <- name

           static member addToContext (context:MzIdentMLContext) (item:Measure) =
                (addToContextWithExceptionCheck context item)

           static member insert (context:MzIdentMLContext) (item:Measure) =
                (addToContextWithExceptionCheck context item) |> ignore
                insertWithExceptionCheck context

    type SearchDatabaseHandler =
           static member init
                (
                    location                     : string,
                    fileFormat                   : CVParam,
                    databaseName                 : CVParam,
                    ?id                          : int,
                    ?name                        : string,                    
                    ?numDatabaseSequences        : string,
                    ?numResidues                 : string,
                    ?releaseDate                 : DateTime,
                    ?version                     : string,
                    ?externalFormatDocumentation : string,
                    ?details                     : seq<CVParam>             
                ) =
                let id'                          = defaultArg id 0
                let name'                        = defaultArg name null
                let numDatabaseSequences'        = defaultArg numDatabaseSequences null
                let numResidues'                 = defaultArg numResidues null
                let releaseDate'                 = defaultArg releaseDate Unchecked.defaultof<DateTime>
                let version'                     = defaultArg version null
                let externalFormatDocumentation' = defaultArg externalFormatDocumentation null
                let details'                     = convertOptionToList details
                {
                    SearchDatabase.ID                          = id';
                    SearchDatabase.Name                        = name';
                    SearchDatabase.Location                    = location;
                    SearchDatabase.NumDatabaseSequences        = numDatabaseSequences';
                    SearchDatabase.NumResidues                 = numResidues';
                    SearchDatabase.ReleaseDate                 = releaseDate';
                    SearchDatabase.Version                     = version';
                    SearchDatabase.ExternalFormatDocumentation = externalFormatDocumentation';
                    SearchDatabase.FileFormat                  = fileFormat;
                    SearchDatabase.DatabaseName                = databaseName;
                    SearchDatabase.Details                     =  details';
                    SearchDatabase.RowVersion                  = DateTime.Now.Date
                }

           static member addName
                (searchDatabase:SearchDatabase) (name:string) =
                searchDatabase.Name <- name

           static member addNumDatabaseSequences
                (searchDatabase:SearchDatabase) (numDatabaseSequences:string) =
                searchDatabase.NumDatabaseSequences <- numDatabaseSequences

           static member addNumResidues
                (searchDatabase:SearchDatabase) (numResidues:string) =
                searchDatabase.NumResidues <- numResidues

           static member addReleaseDate
                (searchDatabase:SearchDatabase) (releaseDate:DateTime) =
                searchDatabase.ReleaseDate <- releaseDate

           static member addVersion
                (searchDatabase:SearchDatabase) (version:string) =
                searchDatabase.Version <- version

           static member addExternalFormatDocumentation
                (searchDatabase:SearchDatabase) (externalFormatDocumentation:string) =
                searchDatabase.Version <- externalFormatDocumentation

           static member addDetails
                (searchDatabase:SearchDatabase) (details:seq<CVParam>) =
                let result = searchDatabase.Details <- addCollectionToList searchDatabase.Details details
                searchDatabase

            static member addToContext (context:MzIdentMLContext) (item:DBSequence) =
                    (addToContextWithExceptionCheck context item)

            static member insert (context:MzIdentMLContext) (item:DBSequence) =
                    (addToContextWithExceptionCheck context item) |> ignore
                    insertWithExceptionCheck context

    type DBSequenceHandler =
           static member init
                (
                    accession      : string,
                    searchDatabase : SearchDatabase,
                    ?id            : int,
                    ?name          : string,
                    ?sequence      : string,
                    ?length        : int,
                    ?details       : seq<CVParam>                
                ) =
                let id'       = defaultArg id 0
                let name'     = defaultArg name null
                let sequence' = defaultArg sequence null
                let length'   = defaultArg length Unchecked.defaultof<int>
                let details'  = convertOptionToList details
                {
                    DBSequence.ID             = id';
                    DBSequence.Name           = name';
                    DBSequence.Accession      = accession;
                    DBSequence.SearchDatabase = searchDatabase;
                    DBSequence.Sequence       = sequence';
                    DBSequence.Length         = length';
                    DBSequence.Details        = details';
                    DBSequence.RowVersion     = DateTime.Now
                }

           static member addName
                (dbSequence:DBSequence) (name:string) =
                dbSequence.Name <- name

           static member addSequence
                (dbSequence:DBSequence) (sequence:string) =
                dbSequence.Sequence <- sequence

           static member addLength
                (dbSequence:DBSequence) (length:int) =
                dbSequence.Length <- length

           static member addDetail
                (dbSequence:DBSequence) (detail:CVParam) =
                let result = dbSequence.Details <- addToList dbSequence.Details detail
                dbSequence

           static member addDetails
                (dbSequence:DBSequence) (details:seq<CVParam>) =
                let result = dbSequence.Details <- addCollectionToList dbSequence.Details details
                dbSequence

            static member addToContext (context:MzIdentMLContext) (item:DBSequence) =
                    (addToContextWithExceptionCheck context item)

            static member insert (context:MzIdentMLContext) (item:DBSequence) =
                    (addToContextWithExceptionCheck context item) |> ignore
                    insertWithExceptionCheck context


module test =
//Apply functions

    open ObjectHandlers
    open ManipulateDataContextAndDB


    let context = configureSQLiteContextMzIdentML standardDBPathSQLite

    //Term and Ontology
    let termI = TermHandler.init("I")
    let termII = TermHandler.addName termI "Test"
    let ontologyI = OntologyHandler.init("I")
    let termIII = TermHandler.addOntology termII ontologyI
    let addTermtoContext = TermHandler.addToContext context termIII

    let cvParam = CVParamHandler.init("Test", termIII)
    let addCVtoContext = CVParamHandler.addToContext context cvParam

    let analysisSoftware = AnalysisSoftwareHandler.init(cvParam,0)
    let analysisSoftwareName = AnalysisSoftwareHandler.addName analysisSoftware "BoB"
    let addAnalysisSoftwareToContext = AnalysisSoftwareHandler.addToContext context analysisSoftwareName

    let person = PersonHandler.init(0)
    let addpersonToContext = PersonHandler.addToContext context person

    let organization = OrganizationHandler.init(0)
    let addOrganizationToContext = OrganizationHandler.addToContext context organization

    context.Database.EnsureCreated()

    insertWithExceptionCheck context