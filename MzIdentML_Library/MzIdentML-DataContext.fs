namespace Entities_DBContext

//open System
//open System.ComponentModel.DataAnnotations.Schema
//open Microsoft.EntityFrameworkCore
//open System.Collections.Generic
//open FSharp.Care.IO
//open BioFSharp.IO

//module Entities =

//    module BasicTypesOfEntities =

//        ///A modification where one residue is substituted by another (amino acid change).
//        type [<CLIMutable>] 
//            SubstitutionModification =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                    : int
//            Location              : int
//            AvgMassDelta          : float
//            MonoIsotopicMassDelta : float
//            OriginalResidue       : string
//            ReplacementResidue    : string
//            RowVersion            : DateTime 
//            }

//        type [<CLIMutable>] 
//            Term =
//            {
//            ID             : string
//            Name           : string
//            //Ontology       : Ontology
//            RowVersion     : DateTime 
//            }

//        type [<CLIMutable>] 
//            TermRelationShip =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            Term             : string
//            RelationShipType : string
//            RelatedTerm      : string
//            RowVersion       : DateTime     
//            }

//        type [<CLIMutable>] 
//            TermTag =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID         : int
//            Term       : string
//            Name       : string
//            Value      : string
//            RowVersion : DateTime 
//            }

//        type [<CLIMutable>] 
//            UserParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            Type             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Name             : string
//            Value            : string
//            RowVersion       : DateTime    
//            }

//        ///Params for AnalysisParams
//        type [<CLIMutable>] 
//            AnalysisParamsParam =
//             {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            Value            : string
//            RowVersion       : DateTime    
//            }   

//        ///The parameters and settings for the protein etection.
//        type [<CLIMutable>]
//            AnalysisParams =
//            {
//             ID          : int
//             Terms       : List<AnalysisParamsParam>
//             UserParams  : List<UserParam>
//             RowVersion  : DateTime
//            }

//        ///Params for TranslationalTable
//        type [<CLIMutable>] 
//            TranslationTableParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : TranslationTable
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime    
//            }

//        ///The table used to translate codons into nucleic acids e.g. by reference to the NCBI translation table.
//        type [<CLIMutable>] 
//            TranslationTable =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                     : int
//            Name                   : string 
//            TranslationTableParams : List<TranslationTableParam>
//            RowVersion             : DateTime
//            }

//        ///Params for TranslationalTable
//        type [<CLIMutable>] 
//            SpectrumIDFormatParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : TranslationTable
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime    
//            }

//        ///The format of the spectrum identifier within the source file.
//        type [<CLIMutable>] 
//            SpectrumIDFormat =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                    : int
//            SpectrumIDFormatParam : SpectrumIDFormatParam
//            RowVersion            : DateTime 
//            }

//        type [<CLIMutable>] 
//            ThresholdParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime    
//            }   

//        ///The threshold(s) applied to determine that a result is significant. If multiple terms are used it is assumed that all conditions are satisfied by the passing results.
//        type [<CLIMutable>] 
//            Threshold =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID              : int
//            ThresholdParams : List<ThresholdParam>
//            UserParams      : List<UserParam>
//            RowVersion      : DateTime 
//            }

//        type [<CLIMutable>] 
//            SpecificityRulesParam = 
//             {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime    
//            }   

//        ///The specificity rules of the searched modification including for example the probability of a modification's presence or peptide or protein termini. Standard fixed or variable status should be provided by the attribute fixedMod.
//        type [<CLIMutable>] 
//            SpecificityRules =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID         : int
//            Terms      : List<SpecificityRulesParam>
//            RowVersion : DateTime
//            }

//        ///Param to MiIdentML-Table
//        //and [<CLIMutable>] 
//        //    MzIdentMLParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID                         : int
//        //    //FKParamContainer            : MzIdentMLParam
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term                       : string
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Unit                       : string
//        //    Value                      : string
//        //    RowVersion                 : DateTime  
//        //    }

//        ///CvParam for AdditionalSearchParam
//        type [<CLIMutable>] 
//            AdditionalSearchparamsParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : AdditionalSearchparam
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            Value            : string
//            UnitName         : string
//            RowVersion       : DateTime  
//            }

//        ///The searchparameters other than the modifications searched.
//        type [<CLIMutable>] 
//             AdditionalSearchparams =
//             {
//              [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//              ID         : int
//              Term       : List<AdditionalSearchparamsParam>
//              UserParam  : List<UserParam>
//              RowVersion : DateTime
//             }

//        ///The containing organization.
//        type [<CLIMutable>] 
//            Parent =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID              : int            
//            //Name         : string
//            OrganizationRef : string
//            //Country      : string         
//            RowVersion      : DateTime
//            //ParentParams : List<ParentParam>
//            }

//        ///Params of Organization.
//        type [<CLIMutable>] 
//            OrganizationParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : Organization
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///Entity which is responsible for analysis-software, data-file, etc. 
//        type [<CLIMutable>] 
//            Organization =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                 : int
//            Name               : string
//            Parent             : Parent
//            RowVersion         : DateTime
//            OrganizationParams : List<OrganizationParam>
//            UserParams         : List<UserParam>
//            }

//        ///The organization a person belongs to.
//        type [<CLIMutable>]
//            Affiliation =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID              : int
//             OrganizationRef : string
//             RowVersion      : DateTime
//            }

//        ///Params of Person.
//        type [<CLIMutable>] 
//            PersonParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : Person
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime   
//            }

//        ///person's name and contact details.
//        type [<CLIMutable>] 
//            Person =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID           : int
//            Name         : string
//            FirstName    : string 
//            LastName     : string 
//            MiddleName   : string
//            Affiliations : List<Affiliation>
//            //Organization   : Organization
//            RowVersion   : DateTime  
//            PersonParams : List<PersonParam>
//            UserParams   : List<UserParam>
//            }

//        ///CvParam for AmbitousResidue
//        type [<CLIMutable>] 
//            AmbiguousResidueParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : AmbiguousResidue
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime  
//            }

//        ///Ambitous residues describes the range of mass that a specific location shall be checked because its position is ambitous.
//        type [<CLIMutable>]
//            AmbiguousResidue =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID                     : int
//             Code                   : string
//             RowVersion             : DateTime
//             AmbiguousResidueParams : List<AmbiguousResidueParam>
//             UserParams             : List<UserParam>
//            }

//        //type [<CLIMutable>] 
//        //    AnalysisSoftwareParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : AnalysisSoftware
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime  
//        //    }

//        ///The complete set of Contacts (people and organisations) for this file.
//        type [<CLIMutable>]
//            AuditCollection =
//            {
//             ID            : int
//             Persons       : List<Person>
//             Organizations : List<Organization>
//             RowVersion    : DateTime
//            }

//        ///Page-number of BiblioGraphicReference.
//        type [<CLIMutable>] 
//            Page =
//            {
//             ID                     : int
//             PageNumber             : int
//             //BiblioGraphicReference : BiblioGraphicReference
//             RowVersion             : DateTime
//            }

//        ///Any bibliographic references associated with the file.
//        type [<CLIMutable>] 
//            BiblioGraphicReference =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>]
//             ID          : int
//             Name        : string
//             Issue       : string
//             Authors     : string
//             DOI         : string
//             Editor      : string
//             Pages       : string
//             Publication : string
//             Publisher   : string
//             Title       : string
//             Volume      : string
//             Year        : int
//             RowVersion  : DateTime
//            }

//        ///Params of Role.
//        type [<CLIMutable>] 
//            RoleParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : Role
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime  
//            }

//        ///The roles the Contact fills.
//        type [<CLIMutable>] 
//            Role =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID         : int
//            //Name       : string //self added
//            RowVersion : DateTime
//            RoleParams : RoleParam
//            }

//        ///Different details, depending of the kind of contact.
//        type [<CLIMutable>] 
//            ContactRole =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>]
//             ID          : int
//             ContactRef  : string
//             Role        : Role
//             RowVersion  : DateTime
//            }

//        ///Customizations on the analysis-software in the form of a free text.
//        type [<CLIMutable>] 
//            Customizations =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>]
//             ID          : int
//             Description : string
//             RowVersion  : DateTime
//            }

//        ///A source controlled vocabulary from which cvParams will be obtained.
//        type [<CLIMutable>] 
//            CV =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>]
//             ID         : int
//             FullName   : string
//             URL        : string
//             Version    : string
//             RowVersion : DateTime
//            }

//        ///The list of controlled vocabularies used in the file.
//        type [<CLIMutable>]
//            CVList =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>]
//             ID         : int
//             CVs        : List<CV>
//             RowVersion : DateTime
//            }

//        ///Params of CV
//        //type [<CLIMutable>] 
//        //    CVParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : CV
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime  
//        //    }

//        type [<CLIMutable>]
//            ExcludeParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime    
//            } 

//        ///All sequences fulfilling the specifed criteria are excluded.
//        type [<CLIMutable>]
//            Exclude =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID         : int
//             Terms      : List<ExcludeParam>
//             UserParams : List<UserParam>
//             RowVersion : DateTime
//             //ExcludeParams : List<ExcludeParams>
//            }

//        type [<CLIMutable>]
//            IncludeParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime    
//            } 

//        ///All sequences fulfilling the specifed criteria are included.
//        type [<CLIMutable>]
//            Include =
//            {
//             ID         : int
//             Terms      : List<IncludeParam>
//             UserParams : List<UserParam>
//             RowVersion : DateTime
//             //IncludeParams : List<IncludeParam>
//            }

//        ///Params for FilterType.
//        type [<CLIMutable>] 
//            FilterTypeParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : FilterType
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///The type of filter e.g. Database taxonomy filter, pi filter, mw filter.
//        type [<CLIMutable>]
//            FilterType =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID               : int
//             //Name             : string
//             RowVersion       : DateTime
//             FilterTypeParam  : FilterTypeParam
//             UserParam        : UserParam
//            }

//        ///Filters applied to the search Database.
//        type [<CLIMutable>]
//            Filter =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID         : int
//             FilterType : FilterType
//             Exclude    : Exclude
//             Include    : Include
//             RowVersion : DateTime
//            }

//        ///The specification of filters applied to the Database searched.
//        type [<CLIMutable>] 
//            DatabaseFilters =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID             : int
//             Filters        : List<Filter>
//             RowVersion     : DateTime
//            }

//        ///Params for DatabaseName.
//        type [<CLIMutable>] 
//            DatabaseNameParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : FilterType
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///Name of the Database.
//        type [<CLIMutable>]
//            DatabaseName =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID                : int
//             //Name       : string
//             DatabaseNameParam : DatabaseNameParam
//             UserParam         : UserParam
//             RowVersion        : DateTime
//             //DatabseNameParams : List<DatabaseNameParam>
//            }

//        /////Params of DatabseName.
//        //type [<CLIMutable>] 
//        //    DatabaseNameParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : DatabaseName
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime 
//        //    }

//        type [<CLIMutable>] 
//            Frame =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID                  : int
//             Frame               : string
//             //DatabaseTranslation : DatabaseTranslation
//             RowVersion          : DateTime
//            }

//        ///A specification of how a nucleic acid sequence Database was translated for searching.
//        type [<CLIMutable>] 
//            DatabaseTranslation =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID                : int
//             Frames            : string
//             TranslationTables : List<TranslationTable>
//             RowVersion        : DateTime
//            }

//        ///Params of SearchDatabase.
//        type [<CLIMutable>] 
//            SearchDatabaseParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : SearchDatabaseParam
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime  
//            }

//        ///Params of enzyme.
//        type [<CLIMutable>] 
//            EnzymeParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : EnzymeParam
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///Regular expression for specifying the enzyme cleavage site.
//        type [<CLIMutable>] 
//            SiteRegexp =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID         : int
//            Sequence   : string
//            RowVersion : DateTime
//            }

//        type [<CLIMutable>]
//            EnzymeNameParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime    
//            } 

//        type [<CLIMutable>]
//            EnzymeName =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID         : int
//             //Name       : string
//             Terms      : List<EnzymeNameParam>
//             UserParams : List<UserParam>
//             RowVersion : DateTime
//            }

//        ///Infomration about the used cleavage enzyme.
//        type [<CLIMutable>]
//            Enzyme =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID              : int
//             Name            : string
//             SemiSpecific    : string
//             CTermGain       : string
//             NTermGain       : string
//             MinDistance     : int
//             missedCleavages : string
//             SiteRegexp      : SiteRegexp
//             EnzymeNames     : EnzymeName
//             RowVersion      : DateTime
//            }

//        ///List of used enzyme.
//        type [<CLIMutable>]
//            Enzymes =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID          : int
//             Independent : string
//             Enzymes     : List<Enzyme>
//             RowVersion  : DateTime
//            }

//        /////Params of exclude.
//        //type [<CLIMutable>] 
//        //    ExcludeParams =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : Exclude
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime 
//        //    }

//        ///A URI to access documentation and tools to interpret the external format of the ExternalData instance.
//        type [<CLIMutable>]
//            ExternalFormatDocumentation =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID               : int
//             URI              : string //Added because it seemed necessary
//             Format           : string
//             RowVersion       : DateTime
//             //FileFormatParams : List<FileFormatParam>
//            }

//        ///Params for FileFormat.
//        type [<CLIMutable>] 
//            FileFormatParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : FileFormat
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///The format of the ExternalData file.
//        type [<CLIMutable>]
//            FileFormat =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID              : int
//             //Format          : string
//             FileFormatParam : FileFormatParam
//             RowVersion      : DateTime
//            }

//        //Added because it exists in the original document and is referred multiple times in the code.
//        type [<CLIMutable>] 
//            SearchDatabase =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                          : int
//            Name                        : string 
//            Location                    : string //Location of the datafile, commonly an URL
//            NumDatabaseSequences        : int
//            NumResidues                 : int
//            ReleaseDate                 : DateTime
//            Version                     : string
//            ExternalFormatDocumentation : string
//            FileFormat                  : FileFormat
//            DatabaseName                : DatabaseName
//            RowVersion                  : DateTime
//            SearchDatabaseParams        : List<SearchDatabaseParam>
//            }

//        ///Params of DBSequence.
//        type [<CLIMutable>] 
//            DBSequenceParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : DBSequence
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///The actual sequence of amino acids or nucleic acid.
//        type [<CLIMutable>] 
//             Seq =
//             {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID          : int
//             Sequence    : string
//             RowVersion  : DateTime
//             }

//        ///Sequence from the Database search.
//        type [<CLIMutable>] 
//            DBSequence =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            Name             : string
//            Accession        : string
//            Length           : int
//            Seq              : string
//            SearchDBRef      : string
//            RowVersion       : DateTime 
//            DBSequenceParams : List<DBSequenceParam>
//            UserParam        : List<UserParam>
//            }

//        ///Params of Measure.
//        type [<CLIMutable>] 
//            MeasureParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : Measure
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///References to CV terms defining the measures about product ions to be reported in SpectrumIdentificationItem.
//        type [<CLIMutable>] 
//            Measure =
//            {
//            ID              : int
//            Name            : string
//            //MassTable       : MassTable
//            RowVersion      : DateTime
//            MeasureParams   : List<MeasureParam>
//            }


//        ///Flaot value of the FragmentArray.
//        type [<CLIMutable>] 
//            Value =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID         : int
//             Value      : float
//             //FragmentArray : FragmentArray
//             RowVersion : DateTime
//            }

//        ///An array of values for a given type of measure and for a particular ion type, in parallel to the index of ions identified.
//        type [<CLIMutable>] 
//            FragmentArray =
//            {
//             ID         : int
//             Values     : string
//             MeasureRef : string
//             RowVersion : DateTime
//            }

//        ///Params of IonType
//        type [<CLIMutable>] 
//            IonTypeParam =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID               : int
//             ////FKParamContainer  : IonType
//         //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//             Term             : string
//         //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//             Unit             : string
//             UnitName         : string
//             Value            : string
//             RowVersion       : DateTime 
//            }

//        ///The type of ion that has been identified.
//        type [<CLIMutable>]
//            IndexItem =
//            {
//             ID         : int
//             IndexItem  : int
//             RowVersion : DateTime
//            }

//        ///The type of ion that has been identified.
//        type [<CLIMutable>]
//            IonType =
//            {
//             ID             : int
//             //Type          : string 
//             Charge         : int
//             Index          : string
//             FragmentArrays : List<FragmentArray>
//             RowVersion     : DateTime
//             IonTypeParams  : List<IonTypeParam>
//             UserParams     : List<UserParam>
//            }

//        ///The product ions identified in this result.
//        type [<CLIMutable>]
//            Fragmentation =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID         : int
//             IonTypes   : List<IonType>
//             RowVersion : DateTime
//            }

//        ///Contains the types of measures that will be reported in generic arrays for each SpectrumIdentificationItem.
//        type [<CLIMutable>]
//            FragmentationTable =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID         : int
//             Measures   : List<Measure>
//             RowVersion : DateTime
//            }

//        ///Params of FragmentTolerance.
//        type [<CLIMutable>] 
//            FragmentToleranceParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : FragmentTolerance
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///The tolerance of the search given as a plus and minus value with units.
//        type [<CLIMutable>]
//            FragmentTolerance =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID                      : int
//             //Value                   : float
//             RowVersion              : DateTime
//             FragmentToleranceParams : List<FragmentToleranceParam>
//            }

//        /////Params ofInclude.
//        //type [<CLIMutable>] 
//        //    IncludeParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : Include
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime 
//        //    }

//        ///Params of SourceFile
//        type [<CLIMutable>] 
//            SourceFileParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                     : int
//            //FKParamContainer        : SourceFile
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term                   : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit                   : string
//            UnitName               : string
//            Value                  : string
//            RowVersion             : DateTime
//            }

//        ///A file from which this mzIdentML instance was created.
//        type [<CLIMutable>] 
//            SourceFile =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                          : int
//            Name                        : string
//            Location                    : string
//            ExternalFormatDocumentation : string
//            FileFormat                  : FileFormat
//            RowVersion                  : DateTime
//            SourceFileParams            : List<SourceFileParam>
//            UserParams                  : List<UserParam>
//            }

//        ///A data set containing spectra data (consisting of one or more spectra).
//        type [<CLIMutable>] 
//            SpectraData =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                          : int
//            Name                        : string 
//            Location                    : string //Location of the datafile, commonly an URL
//            ExternalFormatDocumentation : string
//            FileFormat                  : FileFormat
//            SpectrumIDFormat            : SpectrumIDFormat
//            RowVersion                  : DateTime
//            //SpectraDataParams : List<SpectraDataParam>
//            }

//        ///The inputs to the analyses including the Databases searched, the spectral data and the source file converted to mzIdentML.
//        type [<CLIMutable>]
//            Inputs =
//            {
//             ID             : int
//             //URL            : string ///Added by self
//             SourceFiles     : List<SourceFile>
//             SearchDatabases : List<SearchDatabase>
//             SpectraDatas    : List<SpectraData>
//             RowVersion      : DateTime
//            }



//        ///One of the spectra data sets used.
//        type [<CLIMutable>]
//            InputSpectra =
//            {
//             ID             : int
//             SpectraData    : string
//             RowVersion     : DateTime
//            }

//        ///The specification of a single residue within the mass table.
//        type [<CLIMutable>] 
//            Residue =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID         : int
//            Sequence   : string
//            Mass       : string
//            RowVersion : DateTime
//            }

//        //Added because entity framework can not handle list of primitive types
//        ///MS spectrum that the MassTable reffers to, e.g. "1" for MS1.
//        type [<CLIMutable>] 
//            MSLevel =
//            {
//            ID              : int
//            MSLevel         : int
//            //MassTable       : MassTable
//            RowVersion      : DateTime
//            }

//        ///Params of MassTable.
//        type [<CLIMutable>] 
//            MassTableParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : MassTable
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///The masses of residues used in the search.
//        type [<CLIMutable>] 
//            MassTable =
//            {
//             ID                : int
//             Name              : string
//             MSLevels          : string
//             Residues          : List<Residue>
//             AmbiguousResidues : List<AmbiguousResidue>
//             RowVersion        : DateTime
//             MassTableParams   : List<MassTableParam>
//             UserParam         : List<UserParam>
//            }

//        ///Params for Ontology.
//        type [<CLIMutable>] 
//            OntologyParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                     : int
//            //FKParamContainer        : Ontology
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term                   : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit                   : string
//            Value                  : string
//            RowVersion             : DateTime
//            }

//        ///Standarized vocabulary for MS-Database.
//        type [<CLIMutable>] 
//            Ontology = 
//            {
//            //[<DatabaseGenerated(DatabaseGeneratedOption.Identity)>]
//            //ID             : int
//            ID             : string
//            RowVersion     : DateTime
//            OntologyParams : List<OntologyParam>
//            Terms          : List<Term>
//            }

//        //type [<CLIMutable>] 
//        //    ParentParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>]
//        //    ID               : int
//        //    ////FKParamContainer  : Parent
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime   
//        //    }

//        ///Params of ParentToleerance.
//        type [<CLIMutable>]
//            ParentToleranceParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>]
//            ID               : int
//            ////FKParamContainer  : Parent
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime   
//            }

//        ///The tolerance of the search given as a plus and minus value with units.
//        type [<CLIMutable>] 
//            ParentTolerance =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                    : int            
//            ParentToleranceParams : List<ParentToleranceParam>     
//            RowVersion            : DateTime
//            }

//        ///Params of Moodification.
//        type [<CLIMutable>] 
//            ModificationParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : Modification
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///A molecule modification specification. For every modification found in the peptide an extra entry should be created.
//        type [<CLIMutable>] 
//            Modification =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                    : int
//            //Name                  : string 
//            Residues              : string 
//            MonoisotopicMassDelta : float 
//            AvgMassDelta          : float 
//            ModLocation           : int 
//            RowVersion            : DateTime 
//            ModificationParams    : List<ModificationParam>
//            }

//        ///Aminoacid sequence of a (poly-) peptide. If substitutions are found, the original sequence should be reported.
//        type [<CLIMutable>] 
//            PeptideSequence =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID         : int
//            Sequence   : string
//            RowVersion : DateTime  
//            //PeptideHypothesisParams      : List<PeptideHypothesisParam>
//            }

//        ///Params of Peptide.
//        type [<CLIMutable>] 
//            PeptideParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : Peptide
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime  
//            }

//        ///One peptide, which can have modifications. The combination of peptide and modification must be unique.
//        type [<CLIMutable>] 
//            Peptide =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                        : int
//            Name                      : string            
//            PeptideSequence           : string
//            Modifications             : List<Modification>
//            SubstitutionModifications : List<SubstitutionModification>
//            RowVersion                : DateTime 
//            PeptideParams             : List<PeptideParam>
//            UserParams                : List<UserParam>
//            }

//        ///Params of PeptideEvidence.
//        type [<CLIMutable>] 
//            PeptideEvidenceParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : PeptideEvidence
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///PeptideEvidence links a specific Peptide element to a specific position in a DBSequence. There MUST only be one PeptideEvidence item per Peptide-to-DBSequence-position.
//        type [<CLIMutable>] 
//            PeptideEvidence =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                    : int
//            Name                  : string
//            DBSequenceRef         : string
//            PeptideRef            : string
//            isDecoy               : string 
//            Frame                 : int 
//            Start                 : int 
//            End                   : int 
//            Pre                   : string 
//            Post                  : string 
//            TranslationTableRef   : string
//            RowVersion            : DateTime 
//            PeptideEvidenceParams : List<PeptideEvidenceParam>
//            UserParams            : List<UserParam>
//            }

//        ///Reference to the PeptideEvidence element identified.
//        type [<CLIMutable>] 
//            PeptideEvidenceRef =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                    : int
//            PeptideEvidenceRef    : string
//            RowVersion            : DateTime 
//            }

//        ///References to the individual component samples within a mixed parent sample.
//        type [<CLIMutable>] 
//            SubSample =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID         : int
//            SampleRef  : string
//            RowVersion : DateTime 
//            }

//        ///Params of Sample.
//        type [<CLIMutable>] 
//            SampleParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : Sample
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime  
//            }

//        ///A description of the sample analysed by mass spectrometry using CVParams or UserParams.
//        type [<CLIMutable>] 
//            Sample =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID           : int
//            Name         : string 
//            ContactRoles : List<ContactRole>
//            SubSample    : List<SubSample>
//            RowVersion   : DateTime
//            SampleParams : List<SampleParam>
//            UserParams   : List<UserParam>
//            }

//        ///The samples analysed can optionally be recorded using CV terms for descriptions. If a composite sample has been analysed, the subsample association can be used to build a hierarchical description.
//        type [<CLIMutable>] 
//            AnalysisSampleCollection =
//            {
//             ID          : int
//             Samples     : List<Sample>
//             RowVersion  : DateTime
//            }

//        ///Params of SpectrumIdentification.
//        type [<CLIMutable>] 
//            SpectrumIdentificationItemParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : SpectrumIdentificationItem
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///An identification of a single (poly)peptide, resulting from querying an input spectra, along with the set of confidence values for that identification.
//        type [<CLIMutable>] 
//            SpectrumIdentificationItem =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                               : int
//            Name                             : string
//            SampleRef                           : string          
//            PeptideRef                       : string
//            MassTableRef                     : string 
//            PassThreshold                    : bool
//            Rank                             : int 
//            CalculatedMassToCharge           : float 
//            ExperimentalMassToCharge         : float
//            ChargeState                      : int
//            CalculatedPI                     : string 
//            Fragmentation                    : Fragmentation
//            PeptideEvidenceRefs              : List<PeptideEvidenceRef>
//            RowVersion                       : DateTime
//            SpectrumIdentificationItemParams : List<SpectrumIdentificationItemParam>
//            UserParams                       : List<UserParam>
//            }

//        ///An identification of a single (poly)peptide, resulting from querying an input spectra, along with the set of confidence values for that identification.
//        type [<CLIMutable>] 
//            SpectrumIdentificationItemRef =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                        : int
//            SpectrumIdentificationRef : string
//            RowVersion                : DateTime
//            }

//        ///Peptide evidence on which this ProteinHypothesis is based by reference to a PeptideEvidence element.
//        type [<CLIMutable>] 
//            PeptideHypothesis =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                             : int
//            PeptideEvidenceRef             : string
//            SpectrumIdentificationItemRefs : List<SpectrumIdentificationItemRef>
//            RowVersion                     : DateTime  
//            //PeptideHypothesisParams      : List<PeptideHypothesisParam>
//            }

//        //type [<CLIMutable>] 
//        //    PeptideHypothesisParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : PeptideHypothesis
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime 
//        //    }

//        //type [<CLIMutable>] 
//        //    ProteinDetectionParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : ProteinDetection
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime
//        //    }

//        ///Params of ProteinDetectionHypothesis.
//        type [<CLIMutable>] 
//            ProteinDetectionHypothesisParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : ProteinDetectionHypothesis
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime
//            }

//        ///A single result of the ProteinDetection analysis.
//        type [<CLIMutable>] 
//            ProteinDetectionHypothesis =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                               : int
//            Name                             : string
//            DBSequenceRef                    : string
//            PassThreshold                    : bool
//            PeptideHypotheses                : List<PeptideHypothesis>
//            RowVersion                       : DateTime  
//            ProteinDetectionHypothesisParams : List<ProteinDetectionHypothesisParam>
//            UserParams                       : List<UserParam>
//            }

//        ///Params of ProteinAmbiguityGroup.
//        type [<CLIMutable>] 
//            ProteinAmbiguityGroupParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : ProteinAmbiguityGroup
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime     
//            }

//        ///A set of logically related results from a protein detection.
//        type [<CLIMutable>] 
//            ProteinAmbiguityGroup =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                          : int
//            Name                        : string 
//            ProteinDetectionHypotheses  : List<ProteinDetectionHypothesis>
//            RowVersion                  : DateTime
//            ProteinAmbiguityGroupParams : List<ProteinAmbiguityGroupParam>
//            UserParams                  : List<UserParam>
//            }

//        ///Params of ProteindetectionList.
//        type [<CLIMutable>] 
//            ProteinDetectionListParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : ProteinDetectionList
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime
//            }

//        ///The protein list resulting from a protein detection process.
//        type [<CLIMutable>] 
//            ProteinDetectionList =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                         : int
//            Name                       : string
//            ProteinAmbiguityGroups     : List<ProteinAmbiguityGroup>
//            RowVersion                 : DateTime
//            ProteinDetectionListParams : List<ProteinDetectionListParam>
//            UserParams                 : List<UserParam>
//            }

//        ///One of the search databases used.
//        type [<CLIMutable>] 
//            SearchDatabaseRef =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID             : int
//            SearchDatabase : string
//            RowVersion     : DateTime
//            }

//        ///Params of SearchDatabaseModification
//        type [<CLIMutable>] 
//            SearchDatabaseModificationParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                     : int
//            //FKParamContainer        : SearchDatabaseModification
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term                   : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit                   : string
//            Value                  : string
//            RowVersion             : DateTime
//            }

//        ///Specification of a search modification as parameter for a spectra search. Contains the name of the modification, the mass, the specificity and whether it is a static modification.
//        type [<CLIMutable>] 
//            SearchDatabaseModification =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                               : int
//            fixedMod                         : bool
//            massDelta                        : float
//            Residues                         : string
//            SpecificityRules                 : SpecificityRules
//            RowVersion                       : DateTime
//            SearchDatabaseModificationParams : List<SearchDatabaseModificationParam>
//            }

//        ///Params of SearchModification
//        type [<CLIMutable>] 
//            SearchModificationParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                     : int
//            //FKParamContainer        : SearchModification
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term                   : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit                   : string
//            UnitName               : string
//            Value                  : string
//            RowVersion             : DateTime
//            }

//        ///Specification of a search modification as parameter for a spectra search. Contains the name of the modification, the mass, the specificity and whether it is a static modification.
//        type [<CLIMutable>] 
//            SearchModification =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                       : int
//            FixedMod                 : bool
//            MassDelta                : string
//            Residues                 : string
//            SpecificityRules         : List<SpecificityRules>
//            RowVersion               : DateTime
//            SearchModificationParams : List<SearchModificationParam>
//            }

//        ///The specification of static/variable modifications that are to be considered in the spectra search.
//        type [<CLIMutable>] 
//            ModificationParams =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                    : int
//            SearchModifications   : List<SearchModification> 
//            RowVersion            : DateTime 
//            }

//        /////Params of ModLocation.
//        //type [<CLIMutable>] 
//        //    ModLocationParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : ModLocation
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime 
//        //    }

//        ////Not part of the original document
//        /////Param that describes the location of the modification and the altered residue.
//        //type [<CLIMutable>] 
//        //    ModLocation =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID                : int
//        //    Peptide           : Peptide
//        //    Modification      : Modification
//        //    Location          : int
//        //    Residue           : string
//        //    RowVersion        : DateTime
//        //    ModLocationParams : List<ModLocationParam>
//        //    }

//        ///Params of SearchType.
//        type [<CLIMutable>] 
//            SearchTypeParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : ModLocation
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///The type of search performed e.g. PMF, Tag searches, MS-MS
//        type [<CLIMutable>] 
//            SearchType =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID              : int
//            SearchTypeParam : SearchTypeParam
//            UserParam       : UserParam
//            RowVersion      : DateTime
//            }

//        ///The collection of sequences (DBSequence or Peptide) identified and their relationship between each other (PeptideEvidence) to be referenced elsewhere in the results.
//        type [<CLIMutable>] 
//            SequenceCollection =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            DBSequences      : List<DBSequence>
//            Peptides         : List<Peptide>
//            PeptideEvidences : List<PeptideEvidence>
//            RowVersion       : DateTime
//            }

//        ///Params of SoftwareNameParam.
//        type [<CLIMutable>] 
//            SoftwareNameParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : ModLocation
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///Name of a SoftwarePackage
//        type [<CLIMutable>] 
//            SoftwareName =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                : int
//            //Name              : string
//            SoftwareNameParam : SoftwareNameParam
//            UserParam         : UserParam
//            RowVersion        : DateTime
//            }

//        ///The software used for performing the analyses.
//        type [<CLIMutable>] 
//            AnalysisSoftware =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                     : int
//            Name                   : string
//            URI                    : string
//            ContactRole            : ContactRole
//            SoftwareName           : SoftwareName
//            Customizations         : string
//            Version                : string
//            RowVersion             : DateTime
//            //AnalysisSoftwareParams : List<AnalysisSoftwareParam>  
//            }

//        ///List of analysis softwares.
//        type [<CLIMutable>] 
//            AnalysisSoftwareList =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID                : int
//             AnalysisSoftwares : List<AnalysisSoftware>
//             RowVersion        : DateTime
//            }

//        ///The parameters and settings of a ProteinDetection process.
//        type [<CLIMutable>] 
//            ProteinDetectionProtocol =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                             : int
//            Name                           : string 
//            AnalysisSoftwareRef            : string
//            AnalysisParams                 : AnalysisParams
//            Threshold                      : Threshold
//            RowVersion                     : DateTime
//            //ProteinDetectionProtocolParams : List<ProteinDetectionProtocolParam>
//            }

//        //type [<CLIMutable>] 
//        //    ProteinDetectionProtocolParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : ProteinDetectionProtocol
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime  
//        //    }

//        ///The Provider of the mzIdentML record in terms of the contact and software.
//        type [<CLIMutable>] 
//            Provider =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                  : int
//            Name                : string 
//            AnalysisSoftwareRef : string
//            ContactRole         : ContactRole
//            RowVersion          : DateTime
//            }

//        //type [<CLIMutable>] 
//        //    SpectraDataParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID                     : int
//        //    //FKParamContainer        : SpectraData
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term                   : string
//        //    Unit                   : string
//        //    Value                  : string
//        //    RowVersion             : DateTime
//        //    }

//        //type [<CLIMutable>] 
//        //    SpectrumIdentificationParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID                     : int
//        //    //FKParamContainer        : SpectrumIdentification
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term                   : string
//        //    Unit                   : string
//        //    Value                  : string
//        //    RowVersion             : DateTime
//        //    }

//        type [<CLIMutable>] 
//            SpectrumIdentificationResultParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : SpectrumIdentificationResult
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime    
//            }

//        ///All identifications made from searching one spectrum.
//        type [<CLIMutable>] 
//            SpectrumIdentificationResult =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                                 : int
//            Name                               : string
//            SpectrumID                         : string    //Refers to SpectrumID, unique in the SpectraData for the specific Spectrum
//            SpectraDataRef                     : string       
//            SpectrumIdentificationItems        : List<SpectrumIdentificationItem>
//            RowVersion                         : DateTime 
//            SpectrumIdentificationResultParams : List<SpectrumIdentificationResultParam>
//            UserParams                         : List<UserParam>
//            }

//        ///Params of SpectrumIdentificationList.
//        type [<CLIMutable>] 
//            SpectrumIdentificationListParam =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID               : int
//            ////FKParamContainer  : SpectrumIdentificationList
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Term             : string
//        //context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//            Unit             : string
//            UnitName         : string
//            Value            : string
//            RowVersion       : DateTime 
//            }

//        ///Represents the set of all search results from SpectrumIdentification.
//        type [<CLIMutable>] 
//            SpectrumIdentificationList =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                               : int
//            Name                             : string 
//            NumSequencesSearched             : int
//            FragmentationTable               : FragmentationTable
//            SpectrumIdentificationResults    : List<SpectrumIdentificationResult>
//            RowVersion                       : DateTime
//            SpectrumIdentificationListParams : List<SpectrumIdentificationListParam>
//            UserParams                       : List<UserParam>
//            }

//        ///The parameters and settings of a SpectrumIdentification analysis.
//        type [<CLIMutable>] 
//            SpectrumIdentificationProtocol =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                                   : int
//            Name                                 : string 
//            AnalysisSoftwareRef                  : string
//            SearchType                           : SearchType
//            AdditionalSearchparams               : AdditionalSearchparams
//            ModificationParams                   : ModificationParams
//            Enzymes                              : Enzymes
//            MassTables                           : List<MassTable>
//            FragmentTolerance                    : FragmentTolerance
//            ParentTolerance                      : ParentTolerance
//            Threshold                            : Threshold
//            DatabaseFilters                      : DatabaseFilters
//            Frame                                : string
//            DatabaseTranslation                  : DatabaseTranslation
//            RowVersion                           : DateTime 
//            //SpectrumIdentificationProtocolParams : List<SpectrumIdentificationProtocolParam>
//            }

//        ///An Analysis which tries to identify peptides in input spectra, referencing the database searched, the input spectra, the output results and the protocol that is run.
//        type [<CLIMutable>] 
//            SpectrumIdentification =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//            ID                                : int
//            Name                              : string 
//            ActivityDate                      : DateTime
//            SpectrumIdentificationListRef     : string
//            SpectrumIdentificationProtocolRef : string
//            InputSpectras                     : List<InputSpectra>
//            SearchDatabaseRefs                : List<SearchDatabaseRef>
//            RowVersion                        : DateTime
//            //SpectrumIdentificationParams      : List<SpectrumIdentificationParam>
//            }

//        ///The lists of spectrum identifications that are input to the protein detection process.
//        type [<CLIMutable>]
//            InputSpectrumIdentification =
//            {
//             ID                         : int
//             SpectrumIdentificationList : string
//             RowVersion                 : DateTime
//            }

//        ///An Analysis which assembles a set of peptides to proteins.
//        type [<CLIMutable>] 
//            ProteinDetection =
//            {
//            [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>]
//            ID                           : int
//            Name                         : string
//            ProteinDetectionListRef      : string
//            ProteinDetectionProtocolRef  : string
//            ActivityDate                 : DateTime
//            InputSpectrumIdentifications : List<InputSpectrumIdentification>
//            RowVersion                   : DateTime
//            //ProteinDetectionParams      : List<ProteinDetectionParam>
//            }

//        //type [<CLIMutable>] 
//        //    SpectrumIdentificationProtocolParam =
//        //    {
//        //    [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//        //    ID               : int
//        //    ////FKParamContainer  : SpectrumIdentificationProtocol
//        ////context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
//        //    Term             : string
//        //    Unit             : string
//        //    Value            : string
//        //    RowVersion       : DateTime 
//        //    }

//        ///Maps the input and output data sets.
//        type [<CLIMutable>]
//            AnalysisCollection =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID                      : int
//             SpectrumIdentifications : List<SpectrumIdentification>
//             ProteinDetection        : ProteinDetection
//             RowVersion              : DateTime  
//            }

//        ///Data sets generated by the anaylsis of input and output.
//        type [<CLIMutable>]
//            AnalysisData =
//            {
//             [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//             ID : int
//             SpectrumidentificationLists : List<SpectrumIdentificationList>
//             ProteindetectionList        : ProteinDetectionList
//             RowVersion                  : DateTime
//            }

//        ///Collection of the Protocols of the analyses.
//        type [<CLIMutable>] 
//            AnalysisProtocolCollection =
//            {
//             ID                              : int
//             SpectrumIdentificationProtocols : List<SpectrumIdentificationProtocol>
//             ProteinDetectionProtocol        : ProteinDetectionProtocol
//             RowVersion                      : DateTime
//            }

//        ///The collection of input and output data sets of the analyses.
//        type [<CLIMutable>]
//            DataCollection =
//            {
//             ID            : int
//             Inputs        : Inputs
//             AnalysisData  : AnalysisData
//             RowVersion    : DateTime
//            }

//        ///Upper-most hierarchy of MzIdentML with sub-containers to describe relations of data. 
//        type [<CLIMutable>] 
//             MzIdentML =
//             {
//              [<DatabaseGenerated(DatabaseGeneratedOption.Identity)>] 
//              ID                         : int
//              Name                       : string
//              Version                    : string
//              CreationDate               : DateTime
//              CVList                     : CVList
//              AnalysisSoftwareList       : AnalysisSoftwareList
//              Provider                   : Provider
//              AuditCollection            : AuditCollection
//              AnalysisSampleCollection   : AnalysisSampleCollection
//              SequenceCollection         : SequenceCollection
//              AnalysisCollection         : AnalysisCollection
//              AnalysisProtocolCollection : AnalysisProtocolCollection
//              DataCollection             : DataCollection
//              BiblioGraphicReferences    : List<BiblioGraphicReference>
//              RowVersion                 : DateTime
//              //MzIdentMLParams : List<MzIdentMLParam>
//             }

//    module DBContext =

//        open BasicTypesOfEntities

//        ///Defining Context of DB
//        type DBMSContext =

//            inherit DbContext

//            new() = {inherit DbContext()}
//            new(options : DbContextOptions<DBMSContext>) = { inherit DbContext(options) }
    
//            [<DefaultValue>] 
//            val mutable m_mzIdentML : DbSet<MzIdentML>
//            member public this.MzIdentML with get() = this.m_mzIdentML
//                                                        and set value = this.m_mzIdentML <- value

//            //[<DefaultValue>] 
//            //val mutable m_mzIdentMLParam : DbSet<MzIdentMLParam>
//            //member public this.MzIdentMLParam with get() = this.m_mzIdentMLParam
//            //                                            and set value = this.m_mzIdentMLParam <- value

//            //[<DefaultValue>] 
//            //val mutable m_additionalSearchParam : DbSet<AdditionalSearchparam>
//            //member public this.AdditionalSearchParam with get() = this.m_additionalSearchParam
//            //                                            and set value = this.m_additionalSearchParam <- value

//            [<DefaultValue>] 
//            val mutable m_additionalSearchParams : DbSet<AdditionalSearchparams>
//            member public this.AdditionalSearchParams with get() = this.m_additionalSearchParams
//                                                        and set value = this.m_additionalSearchParams <- value

//            [<DefaultValue>] 
//            val mutable m_Affiliation : DbSet<Affiliation>
//            member public this.Affiliation with get() = this.m_Affiliation
//                                                        and set value = this.m_Affiliation <- value

//            [<DefaultValue>] 
//            val mutable m_AmbiguousResidue : DbSet<AmbiguousResidue>
//            member public this.AmbiguousResidue with get() = this.m_AmbiguousResidue
//                                                        and set value = this.m_AmbiguousResidue <- value

//            [<DefaultValue>] 
//            val mutable m_AmbiguousResidueParam : DbSet<AmbiguousResidueParam>
//            member public this.AmbiguousResidueParam with get() = this.m_AmbiguousResidueParam
//                                                            and set value = this.m_AmbiguousResidueParam <- value

//            [<DefaultValue>] 
//            val mutable m_analysisCollection : DbSet<AnalysisCollection>
//            member public this.AnalysisCollection with get() = this.m_analysisCollection
//                                                        and set value = this.m_analysisCollection <- value

//            [<DefaultValue>] 
//            val mutable m_analysisData : DbSet<AnalysisData>
//            member public this.AnalysisData with get() = this.m_analysisData
//                                                        and set value = this.m_analysisData <- value

//            [<DefaultValue>] 
//            val mutable m_analysisParams : DbSet<AnalysisParams>
//            member public this.AnalysisParams with get() = this.m_analysisParams
//                                                        and set value = this.m_analysisParams <- value

//            [<DefaultValue>] 
//            val mutable m_analysisProtocolCollection : DbSet<AnalysisProtocolCollection>
//            member public this.AnalysisProtocolCollection with get() = this.m_analysisProtocolCollection
//                                                                    and set value = this.m_analysisProtocolCollection <- value

//            [<DefaultValue>] 
//            val mutable m_analysisSampleCollection : DbSet<AnalysisSampleCollection>
//            member public this.AnalysisSampleCollection with get() = this.m_analysisSampleCollection
//                                                                    and set value = this.m_analysisSampleCollection <- value


//            [<DefaultValue>] 
//            val mutable m_analysisSoftware : DbSet<AnalysisSoftware>
//            member public this.AnalysisSoftware with get() = this.m_analysisSoftware
//                                                        and set value = this.m_analysisSoftware <- value
//            //[<DefaultValue>] 
//            //val mutable m_analysisSoftwareParam : DbSet<AnalysisSoftwareParam>
//            //member public this.AnalysisSoftwareParam with get() = this.m_analysisSoftwareParam
//            //                                            and set value = this.m_analysisSoftwareParam <- value
  
//            [<DefaultValue>] 
//            val mutable m_analysisSoftwareList : DbSet<AnalysisSoftwareList>
//            member public this.AnalysisSoftwareList with get() = this.m_analysisSoftwareList
//                                                        and set value = this.m_analysisSoftwareList <- value

//            [<DefaultValue>] 
//            val mutable m_AuditCollection : DbSet<AuditCollection>
//            member public this.AuditCollection with get() = this.m_AuditCollection
//                                                        and set value = this.m_AuditCollection <- value

//            [<DefaultValue>] 
//            val mutable m_BiblioGraphicReference : DbSet<BiblioGraphicReference>
//            member public this.BiblioGraphicReference with get() = this.m_BiblioGraphicReference
//                                                        and set value = this.m_BiblioGraphicReference <- value

//            [<DefaultValue>] 
//            val mutable m_ContactRole : DbSet<ContactRole>
//            member public this.ContactRole with get() = this.m_ContactRole
//                                                        and set value = this.m_ContactRole <- value

//            [<DefaultValue>] 
//            val mutable m_Customizations : DbSet<Customizations>
//            member public this.Customizations with get() = this.m_Customizations
//                                                        and set value = this.m_Customizations <- value

//            [<DefaultValue>] 
//            val mutable m_CV : DbSet<CV>
//            member public this.CV with get() = this.m_CV
//                                            and set value = this.m_CV <- value

//            [<DefaultValue>] 
//            val mutable m_CVList : DbSet<CVList>
//            member public this.CVList with get() = this.CVList
//                                                and set value = this.CVList <- value

//            //[<DefaultValue>] 
//            //val mutable m_CVParam : DbSet<CVParam>
//            //member public this.CVParam with get() = this.m_CVParam
//            //                                    and set value = this.m_CVParam <- value

//            [<DefaultValue>] 
//            val mutable m_DatabaseFilters : DbSet<DatabaseFilters>
//            member public this.DatabaseFilters with get() = this.m_DatabaseFilters
//                                                        and set value = this.m_DatabaseFilters <- value

//            [<DefaultValue>] 
//            val mutable m_DatabaseName : DbSet<DatabaseName>
//            member public this.DatabaseName with get() = this.m_DatabaseName
//                                                    and set value = this.m_DatabaseName <- value

//            [<DefaultValue>] 
//            val mutable m_DatabaseTranslation : DbSet<DatabaseTranslation>
//            member public this.DatabaseTranslation with get() = this.m_DatabaseTranslation
//                                                            and set value = this.m_DatabaseTranslation <- value

//            [<DefaultValue>] 
//            val mutable m_DataCollection : DbSet<DataCollection>
//            member public this.DataCollection with get() = this.m_DataCollection
//                                                            and set value = this.m_DataCollection <- value

//            [<DefaultValue>] 
//            val mutable m_dbSequence : DbSet<DBSequence>
//            member public this.DBSequence with get() = this.m_dbSequence
//                                                        and set value = this.m_dbSequence <- value

//            [<DefaultValue>] 
//            val mutable m_dbSequenceParam : DbSet<DBSequenceParam>
//            member public this.DBSequenceParam with get() = this.m_dbSequenceParam
//                                                        and set value = this.m_dbSequenceParam <- value

//            [<DefaultValue>] 
//            val mutable m_enzyme : DbSet<Enzyme>
//            member public this.Enzyme with get() = this.m_enzyme
//                                            and set value = this.m_enzyme <- value

//            [<DefaultValue>] 
//            val mutable m_enzymeName : DbSet<EnzymeName>
//            member public this.EnzymeName with get() = this.m_enzymeName
//                                            and set value = this.m_enzymeName <- value

//            [<DefaultValue>] 
//            val mutable m_enzymes : DbSet<Enzymes>
//            member public this.Enzymes with get() = this.m_enzymes
//                                            and set value = this.m_enzymes <- value

//            [<DefaultValue>] 
//            val mutable m_Exclude : DbSet<Exclude>
//            member public this.Exclude with get() = this.m_Exclude
//                                            and set value = this.m_Exclude <- value

//            [<DefaultValue>] 
//            val mutable m_ExternalFormatDocumentation : DbSet<ExternalFormatDocumentation>
//            member public this.ExternalFormatDocumentation with get() = this.m_ExternalFormatDocumentation
//                                                                    and set value = this.m_ExternalFormatDocumentation <- value

//            [<DefaultValue>] 
//            val mutable m_FileFormat : DbSet<FileFormat>
//            member public this.FileFormat with get() = this.m_FileFormat
//                                                        and set value = this.m_FileFormat <- value

//            [<DefaultValue>] 
//            val mutable m_Filter : DbSet<Filter>
//            member public this.Filter with get() = this.m_Filter
//                                                and set value = this.m_Filter <- value

//            [<DefaultValue>] 
//            val mutable m_FilterType : DbSet<FilterType>
//            member public this.FilterType with get() = this.m_FilterType
//                                                and set value = this.m_FilterType <- value

//            [<DefaultValue>] 
//            val mutable m_FragmentArray : DbSet<FragmentArray>
//            member public this.FragmentArray with get() = this.m_FragmentArray
//                                                and set value = this.m_FragmentArray <- value

//            [<DefaultValue>] 
//            val mutable m_Fragmentation : DbSet<Fragmentation>
//            member public this.Fragmentation with get() = this.m_Fragmentation
//                                                and set value = this.m_Fragmentation <- value

//            [<DefaultValue>] 
//            val mutable m_FragmentationTable : DbSet<FragmentationTable>
//            member public this.FragmentationTable with get() = this.m_FragmentationTable
//                                                    and set value = this.m_FragmentationTable <- value

//            [<DefaultValue>] 
//            val mutable m_FragmentTolerance : DbSet<FragmentTolerance>
//            member public this.FragmentTolerance with get() = this.m_FragmentTolerance
//                                                        and set value = this.m_FragmentTolerance <- value

//            [<DefaultValue>] 
//            val mutable m_Include : DbSet<Include>
//            member public this.Include with get() = this.m_Include
//                                                and set value = this.m_Include <- value

//            [<DefaultValue>] 
//            val mutable m_Input : DbSet<Inputs>
//            member public this.Input with get() = this.m_Input
//                                                and set value = this.m_Input <- value

//            [<DefaultValue>] 
//            val mutable m_InputSpectra : DbSet<InputSpectra>
//            member public this.InputSpectra with get() = this.m_InputSpectra
//                                                and set value = this.m_InputSpectra <- value

//            [<DefaultValue>] 
//            val mutable m_InputSpectrumIdentification : DbSet<InputSpectrumIdentification>
//            member public this.InputSpectrumIdentification with get() = this.m_InputSpectrumIdentification
//                                                                and set value = this.m_InputSpectrumIdentification <- value

//            [<DefaultValue>] 
//            val mutable m_IonType : DbSet<IonType>
//            member public this.IonType with get() = this.m_IonType
//                                                and set value = this.m_IonType <- value

//            [<DefaultValue>] 
//            val mutable m_masstable : DbSet<MassTable>
//            member public this.Masstable with get() = this.m_masstable
//                                                        and set value = this.m_masstable <- value

//            [<DefaultValue>] 
//            val mutable m_masstableParam : DbSet<MassTableParam>
//            member public this.MasstableParam with get() = this.m_masstableParam
//                                                        and set value = this.m_masstableParam <- value

//            [<DefaultValue>] 
//            val mutable m_Measure : DbSet<Measure>
//            member public this.Measure with get() = this.m_Measure
//                                                and set value = this.m_Measure <- value

//            [<DefaultValue>] 
//            val mutable m_modification : DbSet<Modification>
//            member public this.Modification with get() = this.m_modification
//                                                        and set value = this.m_modification <- value

//            [<DefaultValue>] 
//            val mutable m_modificationParam : DbSet<ModificationParam>
//            member public this.ModificationParam with get() = this.m_modificationParam
//                                                        and set value = this.m_modificationParam <- value

//            //[<DefaultValue>] 
//            //val mutable m_modLocation : DbSet<ModLocation>
//            //member public this.ModLocation with get() = this.m_modLocation
//            //                                            and set value = this.m_modLocation <- value

//            //[<DefaultValue>] 
//            //val mutable m_modLocationParam : DbSet<ModLocationParam>
//            //member public this.ModLocationParam with get() = this.m_modLocationParam
//            //                                            and set value = this.m_modLocationParam <- value

//            [<DefaultValue>] 
//            val mutable m_ontology : DbSet<Ontology>
//            member public this.Ontology with get() = this.m_ontology
//                                                        and set value = this.m_ontology <- value

//            [<DefaultValue>] 
//            val mutable m_organization : DbSet<Organization>
//            member public this.Organization with get() = this.m_organization
//                                                        and set value = this.m_organization <- value

//            [<DefaultValue>] 
//            val mutable m_organizationParam : DbSet<OrganizationParam>
//            member public this.OrganizationParam with get() = this.m_organizationParam
//                                                        and set value = this.m_organizationParam <- value

//            [<DefaultValue>] 
//            val mutable m_parent : DbSet<Parent>
//            member public this.Parent with get() = this.m_parent
//                                                        and set value = this.m_parent <- value

//            [<DefaultValue>] 
//            val mutable m_parentTolerance : DbSet<ParentTolerance>
//            member public this.ParentTolerance with get() = this.m_parentTolerance
//                                                        and set value = this.m_parentTolerance <- value

//            [<DefaultValue>] 
//            val mutable m_peptide : DbSet<Peptide>
//            member public this.Peptide with get() = this.m_peptide
//                                                        and set value = this.m_peptide <- value

//            [<DefaultValue>] 
//            val mutable m_peptideParam : DbSet<PeptideParam>
//            member public this.PeptideParam with get() = this.m_peptideParam
//                                                        and set value = this.m_peptideParam <- value

//            [<DefaultValue>] 
//            val mutable m_peptideEvidence : DbSet<PeptideEvidence>
//            member public this.PeptideEvidence with get() = this.m_peptideEvidence
//                                                        and set value = this.m_peptideEvidence <- value

//            [<DefaultValue>] 
//            val mutable m_peptideEvidenceRef : DbSet<PeptideEvidenceRef>
//            member public this.PeptideEvidenceRef with get() = this.m_peptideEvidenceRef
//                                                        and set value = this.m_peptideEvidenceRef <- value

//            [<DefaultValue>] 
//            val mutable m_peptideEvidenceParam : DbSet<PeptideEvidenceParam>
//            member public this.PeptideEvidenceParam with get() = this.m_peptideEvidenceParam
//                                                        and set value = this.m_peptideEvidenceParam <- value

//            [<DefaultValue>] 
//            val mutable m_peptideHypothesis : DbSet<PeptideHypothesis>
//            member public this.PeptideHypothesis with get() = this.m_peptideHypothesis
//                                                        and set value = this.m_peptideHypothesis <- value

//            //[<DefaultValue>] 
//            //val mutable m_peptideHypothesisParam : DbSet<PeptideHypothesisParam>
//            //member public this.PeptideHypothesisParam with get() = this.m_peptideHypothesisParam
//            //                                            and set value = this.m_peptideHypothesisParam <- value

//            [<DefaultValue>] 
//            val mutable m_PeptideSequence : DbSet<PeptideSequence>
//            member public this.PeptideSequence with get() = this.m_PeptideSequence
//                                                        and set value = this.m_PeptideSequence <- value

//            [<DefaultValue>] 
//            val mutable m_person : DbSet<Person>
//            member public this.Person with get() = this.m_person
//                                                        and set value = this.m_person <- value

//            [<DefaultValue>] 
//            val mutable m_personParam : DbSet<Person>
//            member public this.PersonParam with get() = this.m_personParam
//                                                        and set value = this.m_personParam <- value

//            [<DefaultValue>] 
//            val mutable m_proteinAmbiguityGroup : DbSet<ProteinAmbiguityGroup>
//            member public this.ProteinAmbiguityGroup with get() = this.m_proteinAmbiguityGroup
//                                                        and set value = this.m_proteinAmbiguityGroup <- value

//            [<DefaultValue>] 
//            val mutable m_proteinAmbiguityGroupParam : DbSet<ProteinAmbiguityGroupParam>
//            member public this.ProteinAmbiguityGroupParam with get() = this.m_proteinAmbiguityGroupParam
//                                                            and set value = this.m_proteinAmbiguityGroupParam <- value

//            [<DefaultValue>] 
//            val mutable m_proteinDetection : DbSet<ProteinDetection>
//            member public this.ProteinDetection with get() = this.m_proteinDetection
//                                                            and set value = this.m_proteinDetection <- value

//            //[<DefaultValue>] 
//            //val mutable m_proteinDetectionParam : DbSet<ProteinDetectionParam>
//            //member public this.ProteinDetectionParam with get() = this.m_proteinDetectionParam
//            //                                                and set value = this.m_proteinDetectionParam <- value

//            [<DefaultValue>] 
//            val mutable m_proteinDetectionHypothesis : DbSet<ProteinDetectionHypothesis>
//            member public this.ProteinDetectionHypothesis with get() = this.m_proteinDetectionHypothesis
//                                                            and set value = this.m_proteinDetectionHypothesis <- value

//            [<DefaultValue>] 
//            val mutable m_proteinDetectionHypothesisParam : DbSet<ProteinDetectionHypothesisParam>
//            member public this.ProteinDetectionHypothesisParam with get() = this.m_proteinDetectionHypothesisParam
//                                                               and set value = this.m_proteinDetectionHypothesisParam <- value

//            [<DefaultValue>] 
//            val mutable m_proteinDetectionList : DbSet<ProteinDetectionList>
//            member public this.ProteinDetectionList with get() = this.m_proteinDetectionList
//                                                            and set value = this.m_proteinDetectionList <- value

//            [<DefaultValue>] 
//            val mutable m_proteinDetectionListParam : DbSet<ProteinDetectionListParam>
//            member public this.ProteinDetectionListParam with get() = this.m_proteinDetectionListParam
//                                                            and set value = this.m_proteinDetectionListParam <- value

//            [<DefaultValue>] 
//            val mutable m_proteinDetectionProtocol : DbSet<ProteinDetectionProtocol>
//            member public this.ProteinDetectionProtocol with get() = this.m_proteinDetectionProtocol
//                                                            and set value = this.m_proteinDetectionProtocol <- value

//            //[<DefaultValue>] 
//            //val mutable m_proteinDetectionProtocolParam : DbSet<ProteinDetectionProtocolParam>
//            //member public this.ProteinDetectionProtocolParam with get() = this.m_proteinDetectionProtocolParam
//            //                                                    and set value = this.m_proteinDetectionProtocolParam <- value

//            [<DefaultValue>] 
//            val mutable m_Provider : DbSet<Provider>
//            member public this.Provider with get() = this.m_Provider
//                                                and set value = this.m_Provider <- value

//            [<DefaultValue>] 
//            val mutable m_Residue : DbSet<Residue>
//            member public this.Residue with get() = this.m_Residue
//                                                and set value = this.m_Residue <- value

//            [<DefaultValue>] 
//            val mutable m_Role : DbSet<Role>
//            member public this.Role with get() = this.m_Role
//                                                and set value = this.m_Role <- value

//            [<DefaultValue>] 
//            val mutable m_sample : DbSet<Sample>
//            member public this.Sample with get() = this.m_sample
//                                                and set value = this.m_sample <- value

//            [<DefaultValue>] 
//            val mutable m_sampleParam : DbSet<SampleParam>
//            member public this.SampleParam with get() = this.m_sampleParam
//                                                                and set value = this.m_sampleParam <- value

//            [<DefaultValue>] 
//            val mutable m_searchDatabase : DbSet<SearchDatabase>
//            member public this.SearchDatabase with get() = this.m_searchDatabase
//                                                    and set value = this.m_searchDatabase <- value

//            [<DefaultValue>] 
//            val mutable m_searchDatabaseParam : DbSet<SearchDatabaseParam>
//            member public this.SearchDatabaseParam with get() = this.m_searchDatabaseParam
//                                                        and set value = this.m_searchDatabaseParam <- value

//            [<DefaultValue>] 
//            val mutable m_searchDatabaseRef : DbSet<SearchDatabaseRef>
//            member public this.SearchDatabaseRef with get() = this.m_searchDatabaseRef
//                                                        and set value = this.m_searchDatabaseRef <- value

//            [<DefaultValue>] 
//            val mutable m_SearchModification : DbSet<SearchModification>
//            member public this.SearchModification with get() = this.m_SearchModification
//                                                        and set value = this.m_SearchModification <- value

//            [<DefaultValue>] 
//            val mutable m_SearchType : DbSet<SearchType>
//            member public this.SearchType with get() = this.m_SearchType
//                                                    and set value = this.m_SearchType <- value

//            [<DefaultValue>] 
//            val mutable m_seq : DbSet<Seq>
//            member public this.Seq with get() = this.m_seq
//                                            and set value = this.m_seq <- value

//            [<DefaultValue>] 
//            val mutable m_sequenceCollection : DbSet<SequenceCollection>
//            member public this.SequenceCollection with get() = this.m_sequenceCollection
//                                                        and set value = this.m_sequenceCollection <- value

//            [<DefaultValue>] 
//            val mutable m_siteRegexp : DbSet<SiteRegexp>
//            member public this.SiteRegexp with get() = this.m_siteRegexp
//                                                    and set value = this.m_siteRegexp <- value

//            [<DefaultValue>] 
//            val mutable m_softwareName : DbSet<SoftwareName>
//            member public this.SoftwareName with get() = this.m_softwareName
//                                                    and set value = this.m_softwareName <- value

//            [<DefaultValue>] 
//            val mutable m_sourceFile : DbSet<SourceFile>
//            member public this.SourceFile with get() = this.m_sourceFile
//                                                    and set value = this.m_sourceFile <- value

//            [<DefaultValue>] 
//            val mutable m_specificityRules : DbSet<SpecificityRules>
//            member public this.SpecificityRules with get() = this.m_specificityRules
//                                                    and set value = this.m_specificityRules <- value

//            [<DefaultValue>] 
//            val mutable m_spectraData : DbSet<SpectraData>
//            member public this.SpectraData with get() = this.m_spectraData
//                                                        and set value = this.m_spectraData <- value

//            //[<DefaultValue>] 
//            //val mutable m_spectraDataParam : DbSet<SpectraDataParam>
//            //member public this.SpectraDataParam with get() = this.m_spectraDataParam
//            //                                            and set value = this.m_spectraDataParam <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIdentification : DbSet<SpectrumIdentification>
//            member public this.SpectrumIdentification with get() = this.m_spectrumIdentification
//                                                            and set value = this.m_spectrumIdentification <- value

//            //[<DefaultValue>] 
//            //val mutable m_spectrumIdentificationParam : DbSet<SpectrumIdentificationParam>
//            //member public this.SpectrumIdentificationParam with get() = this.m_spectrumIdentificationParam
//            //                                                and set value = this.m_spectrumIdentificationParam <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIdentificationItem : DbSet<SpectrumIdentificationItem>
//            member public this.SpectrumIdentificationItem with get() = this.m_spectrumIdentificationItem
//                                                                and set value = this.m_spectrumIdentificationItem <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIdentificationItemParam : DbSet<SpectrumIdentificationItemParam>
//            member public this.SpectrumIdentificationItemParam with get() = this.m_spectrumIdentificationItemParam
//                                                               and set value = this.m_spectrumIdentificationItemParam <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIdentificationItemRef : DbSet<SpectrumIdentificationItemRef>
//            member public this.SpectrumIdentificationItemRef with get() = this.m_spectrumIdentificationItemRef
//                                                                    and set value = this.m_spectrumIdentificationItemRef <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIdentificationList : DbSet<SpectrumIdentificationList>
//            member public this.SpectrumIdentificationList with get() = this.m_spectrumIdentificationList
//                                                            and set value = this.m_spectrumIdentificationList <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIdentificationListParam : DbSet<SpectrumIdentificationListParam>
//            member public this.SpectrumIdentificationListParam with get() = this.m_spectrumIdentificationListParam
//                                                                and set value = this.m_spectrumIdentificationListParam <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIdentificationProtocol : DbSet<SpectrumIdentificationProtocol>
//            member public this.SpectrumIdentificationProtocol with get() = this.m_spectrumIdentificationProtocol
//                                                                and set value = this.m_spectrumIdentificationProtocol <- value

//            //[<DefaultValue>] 
//            //val mutable m_spectrumIdentificationProtocolParam : DbSet<SpectrumIdentificationProtocolParam>
//            //member public this.SpectrumIdentificationProtocolParam with get() = this.m_spectrumIdentificationProtocolParam
//            //                                                        and set value = this.m_spectrumIdentificationProtocolParam <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIdentificationResult : DbSet<SpectrumIdentificationResult>
//            member public this.SpectrumIdentificationResult with get() = this.m_spectrumIdentificationResult
//                                                            and set value = this.m_spectrumIdentificationResult <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIdentificationResultParam : DbSet<SpectrumIdentificationResultParam>
//            member public this.SpectrumIdentificationResultParam with get() = this.m_spectrumIdentificationResultParam
//                                                                    and set value = this.m_spectrumIdentificationResultParam <- value

//            [<DefaultValue>] 
//            val mutable m_spectrumIDFormat : DbSet<SpectrumIDFormat>
//            member public this.SpectrumIDFormat with get() = this.m_spectrumIDFormat
//                                                and set value = this.m_spectrumIDFormat <- value

//            [<DefaultValue>] 
//            val mutable m_subSample : DbSet<SubSample>
//            member public this.SubSample with get() = this.m_subSample
//                                                and set value = this.m_subSample <- value

//            [<DefaultValue>] 
//            val mutable m_substitutionModification : DbSet<SubstitutionModification>
//            member public this.SubstitutionModification with get() = this.m_substitutionModification
//                                                                and set value = this.m_substitutionModification <- value

//            [<DefaultValue>] 
//            val mutable m_term : DbSet<Term>
//            member public this.Term with get() = this.m_term
//                                                and set value = this.m_term <- value

//            [<DefaultValue>] 
//            val mutable m_termRelationShip : DbSet<TermRelationShip>
//            member public this.TermRelationShip with get() = this.m_termRelationShip
//                                                and set value = this.m_termRelationShip <- value

//            [<DefaultValue>] 
//            val mutable m_termTag : DbSet<TermTag>
//            member public this.TermTag with get() = this.m_termTag
//                                                and set value = this.m_termTag <- value

//            [<DefaultValue>] 
//            val mutable m_Threshold : DbSet<Threshold>
//            member public this.Threshold with get() = this.m_Threshold
//                                                and set value = this.m_Threshold <- value

//            [<DefaultValue>] 
//            val mutable m_translationTable : DbSet<TranslationTable>
//            member public this.TranslationTable with get() = this.m_translationTable
//                                                    and set value = this.m_translationTable <- value

//            [<DefaultValue>] 
//            val mutable m_translationTableParam : DbSet<TranslationTableParam>
//            member public this.TranslationTableParam with get() = this.m_translationTableParam
//                                                            and set value = this.m_translationTableParam <- value

//            [<DefaultValue>] 
//            val mutable m_userParam : DbSet<UserParam>
//            member public this.UserParam with get() = this.m_userParam
//                                                and set value = this.m_userParam <- value

//            //override this.OnConfiguring (optionsBuilder :  DbContextOptionsBuilder) =
//            //    let fileDir = __SOURCE_DIRECTORY__ 
//            //    let dbContext = fileDir + "\Ontologies_Terms\MSDatenbank.db"
//            //    optionsBuilder.EnableSensitiveDataLogging() |> ignore
//            //    optionsBuilder.UseSqlite(@"Data Source="+ dbContext) |> ignore

//        let fileDir = __SOURCE_DIRECTORY__
//        let standardDBPath = fileDir + "\Ontologies_Terms\MSDatenbank.db"

//        ///Manipulate DB-Context
//        let configureSQLiteServerContext path = 
//            let optionsBuilder = new DbContextOptionsBuilder<DBMSContext>()
//            optionsBuilder.UseSqlite(@"Data Source=" + path) |> ignore
//            new DBMSContext(optionsBuilder.Options)

//module InsertStatements =
//    open Entities
//    open Entities.BasicTypesOfEntities
    
//    let createMzIdentML name version creationDate cvList analysisSoftwareList provider auditCollection analysisSampleCollection sequenceCollection analysisCollection analysisProtocolCollection dataCollection biblioGraphicReference =
//        {
//         MzIdentML.ID                         = 0
//         MzIdentML.Name                       = name
//         MzIdentML.Version                    = version
//         MzIdentML.CreationDate               = creationDate
//         MzIdentML.CVList                     = cvList
//         MzIdentML.AnalysisSoftwareList       = analysisSoftwareList
//         MzIdentML.Provider                   = provider
//         MzIdentML.AuditCollection            = auditCollection
//         MzIdentML.AnalysisSampleCollection   = analysisSampleCollection
//         MzIdentML.SequenceCollection         = sequenceCollection
//         MzIdentML.AnalysisCollection         = analysisCollection
//         MzIdentML.AnalysisProtocolCollection = analysisProtocolCollection
//         MzIdentML.DataCollection             = dataCollection
//         MzIdentML.BiblioGraphicReferences    = biblioGraphicReference
//         MzIdentML.RowVersion                 = DateTime.Now.Date
//        }

//    let createAdditionalSearchParamsParam (*ambiguousResidue*) value term unit unitName =
//        {
//         AdditionalSearchparamsParam.ID         = 0
//         //AmbiguousResidueParam.//FKParamContainer  = ambiguousResidue
//         AdditionalSearchparamsParam.Value      = value
//         AdditionalSearchparamsParam.Term       = term
//         AdditionalSearchparamsParam.Unit       = unit
//         AdditionalSearchparamsParam.UnitName   = unitName
//         AdditionalSearchparamsParam.RowVersion = DateTime.Now.Date
//        }

//    let createAdditionalSearchParams term userParam =
//        {
//         AdditionalSearchparams.ID         = 0
//         AdditionalSearchparams.Term       = term
//         AdditionalSearchparams.UserParam  = userParam
//         AdditionalSearchparams.RowVersion = DateTime.Now.Date
//        }
    
//    let createAffiliation organizationRef =
//        {
//         Affiliation.ID              = 0
//         Affiliation.OrganizationRef = organizationRef
//         Affiliation.RowVersion      = DateTime.Now.Date
//        }

//    let createAmbiguousResidue code ambitousResidueParams userParams =
//        {
//         AmbiguousResidue.ID                     = 0
//         AmbiguousResidue.Code                   = code
//         AmbiguousResidue.RowVersion             = DateTime.Now.Date
//         AmbiguousResidue.AmbiguousResidueParams = ambitousResidueParams
//         AmbiguousResidue.UserParams             = userParams
//        }

//    let createAmbiguousResidueParam (*ambiguousResidue*) value term unit unitName =
//        {
//         AmbiguousResidueParam.ID               = 0
//         //AmbiguousResidueParam.//FKParamContainer  = ambiguousResidue
//         AmbiguousResidueParam.Value            = value
//         AmbiguousResidueParam.Term             = term
//         AmbiguousResidueParam.Unit             = unit
//         AmbiguousResidueParam.UnitName         = unitName
//         AmbiguousResidueParam.RowVersion       = DateTime.Now.Date
//        }
    
//    let createAnalysisCollection proteinDetection spectrumIdentification =
//        {
//         AnalysisCollection.ID                      = 0
//         AnalysisCollection.ProteinDetection        = proteinDetection
//         AnalysisCollection.SpectrumIdentifications = spectrumIdentification
//         AnalysisCollection.RowVersion              = DateTime.Now.Date
//        }

//    let createAnalysisData spectrumidentificationList proteindetectionList =
//        {
//         AnalysisData.ID                          = 0
//         AnalysisData.SpectrumidentificationLists = spectrumidentificationList
//         AnalysisData.ProteindetectionList        = proteindetectionList
//         AnalysisData.RowVersion                  = DateTime.Now.Date
//        }

//    let createAnalysisParamsParam  value term unit =
//        {
//         AnalysisParamsParam.ID               = 0
//         AnalysisParamsParam.Value            = value
//         AnalysisParamsParam.Term             = term
//         AnalysisParamsParam.Unit             = unit
//         AnalysisParamsParam.RowVersion       = DateTime.Now.Date
//        }

//    let createAnalysisParams terms userParams =
//        {
//         AnalysisParams.ID         = 0
//         AnalysisParams.Terms      = terms
//         AnalysisParams.UserParams = userParams
//         AnalysisParams.RowVersion = DateTime.Now.Date
//        }

//    let createAnalysisProtocolCollection spectrumIdentificationProtocols proteinDetectionProtocol =
//        {
//         AnalysisProtocolCollection.ID                              = 0
//         AnalysisProtocolCollection.SpectrumIdentificationProtocols = spectrumIdentificationProtocols
//         AnalysisProtocolCollection.ProteinDetectionProtocol        = proteinDetectionProtocol
//         AnalysisProtocolCollection.RowVersion                      = DateTime.Now.Date
//        }

//    let createAnalysisSampleCollection samples =
//        {
//         AnalysisSampleCollection.ID         = 0
//         AnalysisSampleCollection.Samples    = samples
//         AnalysisSampleCollection.RowVersion = DateTime.Now.Date
//        }

//    let createAnalysisSoftware name uri contactRole softwareName customizations version =
//        {
//         AnalysisSoftware.ID             = 0
//         AnalysisSoftware.Name           = name
//         AnalysisSoftware.URI            = uri
//         AnalysisSoftware.ContactRole    = contactRole
//         AnalysisSoftware.SoftwareName   = softwareName
//         AnalysisSoftware.Customizations = customizations
//         AnalysisSoftware.Version        = version
//         AnalysisSoftware.RowVersion     = DateTime.Now.Date
//         //AnalysisSoftware.AnalysisSoftwareParams = analysisSoftwareParams
//        }

//    //let createAnalysisSoftwareParam analysisSoftware value term unit =
//    //    {
//    //     AnalysisSoftwareParam.ID               = 0
//    //     AnalysisSoftwareParam.//FKParamContainer  = analysisSoftware
//    //     AnalysisSoftwareParam.Value            = value
//    //     AnalysisSoftwareParam.Term             = term
//    //     AnalysisSoftwareParam.Unit             = unit
//    //     AnalysisSoftwareParam.RowVersion       = DateTime.Now.Date
//    //    }

//    let createAnalysisSoftwareList analysisSoftwares =
//        {
//         AnalysisSoftwareList.ID                = 0
//         AnalysisSoftwareList.AnalysisSoftwares = analysisSoftwares
//         AnalysisSoftwareList.RowVersion        = DateTime.Now.Date
//        }

//    let createAuditCollection organization  person =
//        {
//         AuditCollection.ID            = 0
//         AuditCollection.Organizations = organization 
//         AuditCollection.Persons       = person
//         AuditCollection.RowVersion    = DateTime.Now.Date
//        }

//    let createBibliographicReference name issue title pages volume doi editor publication publisher year authors =
//        {
//         BiblioGraphicReference.ID          = 0
//         BiblioGraphicReference.Name        = name
//         BiblioGraphicReference.Issue       = issue
//         BiblioGraphicReference.Title       = title
//         BiblioGraphicReference.Pages       = pages
//         BiblioGraphicReference.Volume      = volume
//         BiblioGraphicReference.DOI         = doi
//         BiblioGraphicReference.Editor      = editor
//         BiblioGraphicReference.Publication = publication
//         BiblioGraphicReference.Publisher   = publisher
//         BiblioGraphicReference.Year        = year
//         BiblioGraphicReference.Authors     = authors
//         BiblioGraphicReference.RowVersion  = DateTime.Now.Date
//        }
    
//    let createPage pageNumber biblioGraphicReference =
//        {
//         Page.ID         = 0
//         Page.PageNumber = pageNumber
//         //Page.BiblioGraphicReference = biblioGraphicReference
//         Page.RowVersion = DateTime.Now.Date
//        }

//    let createContactRole contactRef role =
//        {
//         ContactRole.ID         = 0
//         ContactRole.ContactRef = contactRef
//         ContactRole.Role       = role
//         ContactRole.RowVersion = DateTime.Now.Date
//        }

//    let createCustomizations description =
//        {
//         Customizations.ID          = 0
//         Customizations.Description = description
//         Customizations.RowVersion  = DateTime.Now.Date
//        }

//    let createCV fullName url version =
//        {
//         CV.ID         = 0
//         CV.FullName   = fullName
//         CV.URL        = url
//         CV.Version    = version 
//         CV.RowVersion = DateTime.Now.Date
//        }

//    let createCVList cvs =
//        {
//         CVList.ID         = 0
//         CVList.CVs        = cvs
//         CVList.RowVersion = DateTime.Now.Date
//        }

//    let createDatabaseFilters filters =
//        {
//         DatabaseFilters.ID         = 0
//         DatabaseFilters.Filters    = filters
//         DatabaseFilters.RowVersion = DateTime.Now.Date
//        }

//    let createDatabaseNameParam (*dBSequence*) value term unit unitName =
//        {
//         DatabaseNameParam.ID               = 0
//         //DBSequenceParam.//FKParamContainer  = dBSequence
//         DatabaseNameParam.Value            = value
//         DatabaseNameParam.Term             = term
//         DatabaseNameParam.Unit             = unit
//         DatabaseNameParam.UnitName         = unitName
//         DatabaseNameParam.RowVersion       = DateTime.Now.Date
//        }

//    let createDatabaseName term userParam =
//        {
//         DatabaseName.ID                = 0
//         //DatabaseName.Name       = name
//         DatabaseName.DatabaseNameParam = term
//         DatabaseName.UserParam         = userParam
//         DatabaseName.RowVersion        = DateTime.Now.Date
//        }

//    let createDatabaseTranslation frames translationTables =
//        {
//         DatabaseTranslation.ID                = 0
//         DatabaseTranslation.Frames            = frames
//         DatabaseTranslation.TranslationTables = translationTables
//         DatabaseTranslation.RowVersion        = DateTime.Now.Date
//        }

//    let createFrame frame databasetranslation =
//        {
//         Frame.ID                  = 0
//         Frame.Frame               = frame
//         //Frame.DatabaseTranslation = databasetranslation
//         Frame.RowVersion          = DateTime.Now.Date
//        }

//    let createDataCollection inputs analysisData =
//        {
//         DataCollection.ID           = 0
//         DataCollection.Inputs       = inputs
//         DataCollection.AnalysisData = analysisData
//         DataCollection.RowVersion   = DateTime.Now.Date
//        }

//    let createDBSequence name accession length sequence searchDBRef dBSequenceParams userParams =
//        {
//         DBSequence.ID               = 0
//         DBSequence.Name             = name
//         DBSequence.Accession        = accession
//         DBSequence.Length           = length
//         DBSequence.Seq              = sequence
//         DBSequence.SearchDBRef      = searchDBRef
//         DBSequence.RowVersion       = DateTime.Now.Date
//         DBSequence.DBSequenceParams = dBSequenceParams
//         DBSequence.UserParam        = userParams
//        }

//    let createDBSequenceParam (*dBSequence*) value term unit unitName =
//        {
//         DBSequenceParam.ID               = 0
//         //DBSequenceParam.//FKParamContainer  = dBSequence
//         DBSequenceParam.Value            = value
//         DBSequenceParam.Term             = term
//         DBSequenceParam.Unit             = unit
//         DBSequenceParam.UnitName         = unitName
//         DBSequenceParam.RowVersion       = DateTime.Now.Date
//        }

//    let createEnzyme name cTermGain nTermGain minDistance missedCleavages semiSpecific siteRegexp enzymeParams =
//        {
//         Enzyme.ID              = 0
//         Enzyme.Name            = name
//         Enzyme.missedCleavages = missedCleavages
//         Enzyme.CTermGain       = cTermGain
//         Enzyme.NTermGain       = nTermGain
//         Enzyme.MinDistance     = minDistance
//         Enzyme.SemiSpecific    = semiSpecific
//         Enzyme.SiteRegexp      = siteRegexp
//         Enzyme.RowVersion      = DateTime.Now.Date
//         Enzyme.EnzymeNames     = enzymeParams
//        }

//    let createEnzymeNameParam (*dBSequence*) value term unit unitName =
//        {
//         EnzymeNameParam.ID               = 0
//         //DBSequenceParam.//FKParamContainer  = dBSequence
//         EnzymeNameParam.Value            = value
//         EnzymeNameParam.Term             = term
//         EnzymeNameParam.Unit             = unit
//         EnzymeNameParam.UnitName         = unitName
//         EnzymeNameParam.RowVersion       = DateTime.Now.Date
//        }

//    let createEnzymeName terms userParams =
//        {
//         EnzymeName.ID         = 0
//         //EnzymeName.Name       = name
//         EnzymeName.Terms      = terms
//         EnzymeName.UserParams = userParams
//         EnzymeName.RowVersion = DateTime.Now.Date
//        }

//    let createEnzymes independent enzyme =
//        {
//         Enzymes.ID          = 0
//         Enzymes.Independent = independent
//         Enzymes.Enzymes     = enzyme
//         Enzymes.RowVersion  = DateTime.Now.Date
//        }

//    let createExcludeParam (*dBSequence*) value term unit unitName =
//        {
//         ExcludeParam.ID               = 0
//         //DBSequenceParam.//FKParamContainer  = dBSequence
//         ExcludeParam.Value            = value
//         ExcludeParam.Term             = term
//         ExcludeParam.Unit             = unit
//         ExcludeParam.UnitName         = unitName
//         ExcludeParam.RowVersion       = DateTime.Now.Date
//        }

//    let createExclude terms userParams =
//        {
//         Exclude.ID         = 0
//         Exclude.Terms      = terms
//         Exclude.UserParams = userParams
//         Exclude.RowVersion = DateTime.Now.Date
//        }

//    let createExternalFormatDocumentation uri format =
//        {
//         ExternalFormatDocumentation.ID         = 0
//         ExternalFormatDocumentation.URI        = uri
//         ExternalFormatDocumentation.Format     = format
//         ExternalFormatDocumentation.RowVersion = DateTime.Now.Date
//        }

//    let createFileFormatParam (*dBSequence*) value term unit unitName =
//        {
//         FileFormatParam.ID               = 0
//         //DBSequenceParam.//FKParamContainer  = dBSequence
//         FileFormatParam.Value            = value
//         FileFormatParam.Term             = term
//         FileFormatParam.Unit             = unit
//         FileFormatParam.UnitName         = unitName
//         FileFormatParam.RowVersion       = DateTime.Now.Date
//        } 

//    let createFileFormat fileFormatParam =
//        {
//         FileFormat.ID              = 0
//         FileFormat.FileFormatParam = fileFormatParam
//         FileFormat.RowVersion      = DateTime.Now.Date
//        }

//    let createFilter filterType exclude includes =
//        {
//         Filter.ID         = 0
//         Filter.FilterType = filterType
//         Filter.Exclude    = exclude
//         Filter.Include    = includes
//         Filter.RowVersion = DateTime.Now.Date
//        }

//    let createFilterTypeParam (*dBSequence*) value term unit unitName =
//        {
//         FilterTypeParam.ID               = 0
//         //DBSequenceParam.//FKParamContainer  = dBSequence
//         FilterTypeParam.Value            = value
//         FilterTypeParam.Term             = term
//         FilterTypeParam.Unit             = unit
//         FilterTypeParam.UnitName         = unitName
//         FilterTypeParam.RowVersion       = DateTime.Now.Date
//        }

//    let createFilterType term userParams =
//        {
//         FilterType.ID              = 0
//         //FilterType.Name             = name
//         FilterType.FilterTypeParam = term
//         FilterType.UserParam       = userParams
//         FilterType.RowVersion      = DateTime.Now.Date
//        }

//    let createFragmentArray values measureRef =
//        {
//         FragmentArray.ID         = 0
//         FragmentArray.Values     = values
//         FragmentArray.MeasureRef = measureRef
//         FragmentArray.RowVersion = DateTime.Now.Date
//        }

//    let createValue value fragmentArray =
//        {
//         Value.ID            = 0
//         Value.Value         = value
//         //Value.FragmentArray = fragmentArray
//         Value.RowVersion    = DateTime.Now.Date
//        }

//    let createFragmentation ionTypes =
//        {
//         Fragmentation.ID         = 0
//         Fragmentation.IonTypes   = ionTypes
//         Fragmentation.RowVersion = DateTime.Now.Date
//        }

//    let createFragmentationTable measures =
//        {
//         FragmentationTable.ID          = 0
//         FragmentationTable.Measures    = measures
//         FragmentationTable.RowVersion  = DateTime.Now.Date
//        }

//    let createFragmentToleranceParam (*dBSequence*) value term unit unitName =
//        {
//         FragmentToleranceParam.ID               = 0
//         //DBSequenceParam.//FKParamContainer  = dBSequence
//         FragmentToleranceParam.Value            = value
//         FragmentToleranceParam.Term             = term
//         FragmentToleranceParam.Unit             = unit
//         FragmentToleranceParam.UnitName         = unitName
//         FragmentToleranceParam.RowVersion       = DateTime.Now.Date
//        }

//    let createFragmentTolerance (*value*) fragmentToleranceParams =
//        {
//         FragmentTolerance.ID                      = 0
//         //FragmentTolerance.Value                   = value
//         FragmentTolerance.RowVersion              = DateTime.Now.Date
//         FragmentTolerance.FragmentToleranceParams = fragmentToleranceParams
//        }

//    let createIncludeParam (*dBSequence*) value term unit unitName =
//        {
//         IncludeParam.ID               = 0
//         //DBSequenceParam.//FKParamContainer  = dBSequence
//         IncludeParam.Value            = value
//         IncludeParam.Term             = term
//         IncludeParam.Unit             = unit
//         IncludeParam.UnitName         = unitName
//         IncludeParam.RowVersion       = DateTime.Now.Date
//        }

//    let createInclude terms userParams =
//        {
//         Include.ID         = 0
//         Include.Terms      = terms
//         Include.UserParams = userParams
//         Include.RowVersion = DateTime.Now.Date
//        }

//    let createInputs searchDatabases sourceFiles spectraDatas =
//        {
//         Inputs.ID              = 0
//         Inputs.SearchDatabases = searchDatabases
//         Inputs.SourceFiles     = sourceFiles
//         Inputs.SpectraDatas    = spectraDatas
//         Inputs.RowVersion      = DateTime.Now.Date
//        }

//    let createInputSpectra spectraData =
//        {
//         InputSpectra.ID          = 0
//         InputSpectra.SpectraData = spectraData
//         InputSpectra.RowVersion  = DateTime.Now.Date
//        }

//    let createInputSpectrumIdentification spectrumIdentificationList =
//        {
//         InputSpectrumIdentification.ID                         = 0
//         InputSpectrumIdentification.SpectrumIdentificationList = spectrumIdentificationList
//         InputSpectrumIdentification.RowVersion                 = DateTime.Now.Date
//        }

//    let createIonType index charge fragmentArrays ionTypeParams userParams =
//        {
//         IonType.ID             = 0
//         IonType.Index          = index
//         IonType.Charge         = charge
//         IonType.FragmentArrays = fragmentArrays
//         IonType.RowVersion     = DateTime.Now.Date
//         IonType.IonTypeParams  = ionTypeParams
//         IonType.UserParams     = userParams
//        }

//    let createIndexItem indexItem =
//        {
//         IndexItem.ID         = 0
//         IndexItem.IndexItem  = indexItem
//         IndexItem.RowVersion = DateTime.Now.Date
//        }

//    let createIonTypeParam (*ionType*) value term unit unitName =
//        {
//         IonTypeParam.ID               = 0
//         //IonTypeParam.//FKParamContainer  = ionType
//         IonTypeParam.Value            = value
//         IonTypeParam.Term             = term
//         IonTypeParam.Unit             = unit
//         IonTypeParam.UnitName         = unitName
//         IonTypeParam.RowVersion       = DateTime.Now.Date
//        }

//    let createMassTable name msLevel ambiguousResidues residues massTableParams userParam =
//        {
//         MassTable.ID                = 0
//         MassTable.Name              = name
//         MassTable.MSLevels          = msLevel
//         MassTable.AmbiguousResidues = ambiguousResidues
//         MassTable.Residues          = residues
//         MassTable.RowVersion        = DateTime.Now.Date
//         MassTable.MassTableParams   = massTableParams
//         MassTable.UserParam         = userParam
//        }

//    let createMassTableParam (*massTable*) value term unit unitName =
//        {
//         MassTableParam.ID               = 0
//         //MassTableParam.//FKParamContainer  = massTable
//         MassTableParam.Value            = value
//         MassTableParam.Term             = term
//         MassTableParam.Unit             = unit
//         MassTableParam.UnitName         = unitName
//         MassTableParam.RowVersion       = DateTime.Now.Date
//        }

//    let createMeasureParam (*massTable*) value term unit unitName =
//        {
//         MeasureParam.ID               = 0
//         //MassTableParam.//FKParamContainer  = massTable
//         MeasureParam.Value            = value
//         MeasureParam.Term             = term
//         MeasureParam.Unit             = unit
//         MeasureParam.UnitName         = unitName
//         MeasureParam.RowVersion       = DateTime.Now.Date
//        }

//    let createMeasure name measureParams =
//        {
//         Measure.ID            = 0
//         Measure.Name          = name
//         Measure.RowVersion    = DateTime.Now.Date
//         Measure.MeasureParams = measureParams
//        }

//    let createModification avgMassDelta monoisotopicMassDelta residues modLocation modificationParams =
//        {
//         Modification.ID                    = 0
//         //Modification.Name                  = name
//         Modification.AvgMassDelta          = avgMassDelta
//         Modification.MonoisotopicMassDelta = monoisotopicMassDelta
//         Modification.Residues              = residues
//         Modification.ModLocation           = modLocation
//         Modification.RowVersion            = DateTime.Now.Date
//         Modification.ModificationParams    = modificationParams
//        }

//    let createModificationParam (*modification*) value term unit unitName =
//        {
//         ModificationParam.ID               = 0
//         //ModificationParam.//FKParamContainer  = modification
//         ModificationParam.Value            = value
//         ModificationParam.Term             = term
//         ModificationParam.Unit             = unit
//         ModificationParam.UnitName         = unitName
//         ModificationParam.RowVersion       = DateTime.Now.Date
//        }

//    let createModificationParams searchModification =
//        {
//         ModificationParams.ID                  = 0
//         ModificationParams.SearchModifications = searchModification
//         ModificationParams.RowVersion          = DateTime.Now.Date
//        }

//    //let createModLocation modification location peptide residue modlocationParams =
//    //    {
//    //     ModLocation.ID                = 0
//    //     ModLocation.Modification      = modification
//    //     ModLocation.Location          = location
//    //     ModLocation.Peptide           = peptide
//    //     ModLocation.Residue           = residue
//    //     ModLocation.RowVersion        = DateTime.Now.Date
//    //     ModLocation.ModLocationParams = modlocationParams
//    //    }

//    //let createModLocationParam (*modLocation*) value term unit =
//    //    {
//    //     ModLocationParam.ID               = 0
//    //     //ModLocationParam.//FKParamContainer  = modLocation
//    //     ModLocationParam.Value            = value
//    //     ModLocationParam.Term             = term
//    //     ModLocationParam.Unit             = unit
//    //     ModLocationParam.RowVersion       = DateTime.Now.Date
//    //    }

//    let createOntology name ontologyParams terms =
//        {
//         //Ontology.ID             = 0
//         Ontology.ID             = name
//         Ontology.RowVersion     = DateTime.Now.Date
//         Ontology.OntologyParams = ontologyParams
//         Ontology.Terms          = terms
//        }

//    let createOntologyParam (*ontology*) value term unit =
//        {
//         OntologyParam.ID               = 0
//         //OntologyParam.FKParamContainer  = ontology
//         OntologyParam.Value            = value
//         OntologyParam.Term             = term
//         OntologyParam.Unit             = unit
//         OntologyParam.RowVersion       = DateTime.Now.Date
//        }

//    let createOrganization name parent organizationParams userParams =
//        {
//         Organization.ID                 = 0
//         Organization.Name               = name
//         Organization.Parent             = parent
//         Organization.RowVersion         = DateTime.Now.Date
//         Organization.OrganizationParams = organizationParams
//         Organization.UserParams         = userParams
//        }

//    let createOrganizationParam (*organization*) value term unit unitName =
//        {
//         OrganizationParam.ID               = 0
//         //OrganizationParam.//FKParamContainer  = organization
//         OrganizationParam.Value            = value
//         OrganizationParam.Term             = term
//         OrganizationParam.Unit             = unit
//         OrganizationParam.UnitName         = unitName
//         OrganizationParam.RowVersion       = DateTime.Now.Date
//        }

//    let createParent organizationRef  =
//        {
//         Parent.ID              = 0
//         //Parent.Name         = name
//         //Parent.Country      = country
//         Parent.OrganizationRef = organizationRef
//         Parent.RowVersion      = DateTime.Now.Date
//         //Parent.ParentParams = parentParams
//        }

//    let createParentToleranceParam value term unit unitName =
//        {
//         ParentToleranceParam.ID               = 0
//         //ParentParam.//FKParamContainer  = parent
//         ParentToleranceParam.Value            = value
//         ParentToleranceParam.Term             = term
//         ParentToleranceParam.Unit             = unit
//         ParentToleranceParam.UnitName         = unitName
//         ParentToleranceParam.RowVersion       = DateTime.Now.Date
//        }

//    let createParentTolerance parentToleranceParams =
//        {
//         ParentTolerance.ID                    = 0
//         ParentTolerance.ParentToleranceParams = parentToleranceParams
//         ParentTolerance.RowVersion            = DateTime.Now.Date
//        }

//    let createPeptide name peptideSequence modification substitutionModifications peptideParams userParams =
//        {
//         Peptide.ID                         = 0
//         Peptide.Name                       = name
//         Peptide.PeptideSequence            = peptideSequence
//         Peptide.Modifications              = modification
//         Peptide.SubstitutionModifications  = substitutionModifications
//         Peptide.RowVersion                 = DateTime.Now.Date
//         Peptide.PeptideParams              = peptideParams
//         Peptide.UserParams = userParams
//        }

//    let createPeptideParam (*peptide*) value term unit unitName =
//        {
//         PeptideParam.ID               = 0
//         //PeptideParam.//FKParamContainer  = peptide
//         PeptideParam.Value            = value
//         PeptideParam.Term             = term
//         PeptideParam.Unit             = unit
//         PeptideParam.UnitName         = unitName
//         PeptideParam.RowVersion       = DateTime.Now.Date
//        }

//    let createPeptideEvidence name peptideRef dBSequenceRef isDecoy frame translationTableRef start ende pre post peptideEvidenceParams userParams =
//        {
//         PeptideEvidence.ID                    = 0
//         PeptideEvidence.Name                  = name
//         PeptideEvidence.PeptideRef            = peptideRef
//         PeptideEvidence.DBSequenceRef         = dBSequenceRef
//         PeptideEvidence.isDecoy               = isDecoy
//         PeptideEvidence.Frame                 = frame
//         PeptideEvidence.TranslationTableRef   = translationTableRef
//         PeptideEvidence.Start                 = start
//         PeptideEvidence.End                   = ende
//         PeptideEvidence.Pre                   = pre
//         PeptideEvidence.Post                  = post
//         PeptideEvidence.RowVersion            = DateTime.Now.Date
//         PeptideEvidence.PeptideEvidenceParams = peptideEvidenceParams
//         PeptideEvidence.UserParams            = userParams
//        }

//    let createPeptideEvidenceParam (*peptideEvidence*) value term unit unitName =
//        {
//         PeptideEvidenceParam.ID               = 0
//         //PeptideEvidenceParam.//FKParamContainer  = peptideEvidence
//         PeptideEvidenceParam.Value            = value
//         PeptideEvidenceParam.Term             = term
//         PeptideEvidenceParam.Unit             = unit
//         PeptideEvidenceParam.UnitName         = unitName
//         PeptideEvidenceParam.RowVersion       = DateTime.Now.Date
//        }

//    let createPeptideEvidenceRef peptideEvidenceRef =
//        {
//         PeptideEvidenceRef.ID                 = 0
//         PeptideEvidenceRef.PeptideEvidenceRef = peptideEvidenceRef
//         PeptideEvidenceRef.RowVersion         = DateTime.Now.Date
//        }

//    let createPeptideHypothesis peptideEvidenceRef spectrumIdentificationItemRef =
//        {
//         PeptideHypothesis.ID                             = 0
//         PeptideHypothesis.PeptideEvidenceRef             = peptideEvidenceRef
//         PeptideHypothesis.SpectrumIdentificationItemRefs = spectrumIdentificationItemRef
//         PeptideHypothesis.RowVersion                     = DateTime.Now.Date
//         //PeptideHypothesis.PeptideHypothesisParams      = peptideHypothesisParams
//        }

//    //let createPeptideHypothesisParam peptideHypothesis value term unit =
//    //    {
//    //     PeptideHypothesisParam.ID               = 0
//    //     PeptideHypothesisParam.//FKParamContainer  = peptideHypothesis
//    //     PeptideHypothesisParam.Value            = value
//    //     PeptideHypothesisParam.Term             = term
//    //     PeptideHypothesisParam.Unit             = unit
//    //     PeptideHypothesisParam.RowVersion       = DateTime.Now.Date
//    //    }

//    let createPeptideSequence sequence =
//        {
//         PeptideSequence.ID         = 0
//         PeptideSequence.Sequence   = sequence
//         PeptideSequence.RowVersion = DateTime.Now.Date
//        }

//    let createPerson name firstName middleName lastName affiliations personenParams userParams =
//        {
//         Person.ID            = 0
//         Person.Name          = name
//         Person.FirstName     = firstName
//         Person.MiddleName    = middleName
//         Person.LastName      = lastName
//         Person.Affiliations  = affiliations
//         //Person.Organization = organization
//         Person.RowVersion    = DateTime.Now.Date
//         Person.PersonParams  = personenParams
//         Person.UserParams    = userParams
//        }

//    let createPersonParam (*person*) value term unit unitName =
//        {
//         PersonParam.ID               = 0
//         //PersonParam.//FKParamContainer  = person
//         PersonParam.Value            = value
//         PersonParam.Term             = term
//         PersonParam.Unit             = unit
//         PersonParam.UnitName         = unitName
//         PersonParam.RowVersion       = DateTime.Now.Date
//        }

//    let createProteinAmbiguityGroup name proteinDetectionHypothesis proteinAmbiguityGroupParams userParams =
//        {
//         ProteinAmbiguityGroup.ID                          = 0
//         ProteinAmbiguityGroup.Name                        = name
//         ProteinAmbiguityGroup.ProteinDetectionHypotheses  = proteinDetectionHypothesis
//         ProteinAmbiguityGroup.RowVersion                  = DateTime.Now.Date
//         ProteinAmbiguityGroup.ProteinAmbiguityGroupParams = proteinAmbiguityGroupParams
//         ProteinAmbiguityGroup.UserParams                  = userParams
//        }

//    let createProteinAmbiguityGroupParam (*proteinAmbiguityGroup*) value term unit unitName =
//        {
//         ProteinAmbiguityGroupParam.ID               = 0
//         //ProteinAmbiguityGroupParam.//FKParamContainer  = proteinAmbiguityGroup
//         ProteinAmbiguityGroupParam.Value            = value
//         ProteinAmbiguityGroupParam.Term             = term
//         ProteinAmbiguityGroupParam.Unit             = unit
//         ProteinAmbiguityGroupParam.UnitName         = unitName
//         ProteinAmbiguityGroupParam.RowVersion       = DateTime.Now.Date
//        }

//    let createProteinDetection name proteinDetectionProtocolRef proteinDetectionListRef inputSpectrumIdentifications activityDate =
//        {
//         ProteinDetection.ID                           = 0
//         ProteinDetection.Name                         = name
//         ProteinDetection.ProteinDetectionProtocolRef  = proteinDetectionProtocolRef
//         ProteinDetection.ProteinDetectionListRef      = proteinDetectionListRef
//         ProteinDetection.InputSpectrumIdentifications = inputSpectrumIdentifications
//         ProteinDetection.ActivityDate                 = activityDate
//         ProteinDetection.RowVersion                   = DateTime.Now.Date
//         //ProteinDetection.ProteinDetectionParams    = proteinDetectionParams
//        }

//    //let createProteinDetectionParam proteinDetection value term unit =
//    //    {
//    //     ProteinDetectionParam.ID               = 0
//    //     ProteinDetectionParam.//FKParamContainer  = proteinDetection
//    //     ProteinDetectionParam.Value            = value
//    //     ProteinDetectionParam.Term             = term
//    //     ProteinDetectionParam.Unit             = unit
//    //     ProteinDetectionParam.RowVersion       = DateTime.Now.Date
//    //    }

//    let createProteinDetectionHypothesis name dBSequenceRef passThreshold peptideHypothesis proteinDetectionHypothesisParams userParams =
//        {
//         ProteinDetectionHypothesis.ID                               = 0
//         ProteinDetectionHypothesis.Name                             = name
//         ProteinDetectionHypothesis.DBSequenceRef                    = dBSequenceRef
//         ProteinDetectionHypothesis.PassThreshold                    = passThreshold
//         ProteinDetectionHypothesis.PeptideHypotheses                = peptideHypothesis
//         ProteinDetectionHypothesis.RowVersion                       = DateTime.Now.Date
//         ProteinDetectionHypothesis.ProteinDetectionHypothesisParams = proteinDetectionHypothesisParams
//         ProteinDetectionHypothesis.UserParams                       = userParams
//        }

//    let createProteinDetectionHypothesisParam (*proteinDetectionHypothesis*) value term unit unitName =
//        {
//         ProteinDetectionHypothesisParam.ID               = 0
//         //ProteinDetectionHypothesisParam.//FKParamContainer  = proteinDetectionHypothesis
//         ProteinDetectionHypothesisParam.Value            = value
//         ProteinDetectionHypothesisParam.Term             = term
//         ProteinDetectionHypothesisParam.UnitName         = unitName
//         ProteinDetectionHypothesisParam.Unit             = unit

//         ProteinDetectionHypothesisParam.RowVersion       = DateTime.Now.Date
//        }

//    let createProteinDetectionList name proteinAmbiguityGroups proteinDetectionListParams userParams =
//        {
//         ProteinDetectionList.ID                         = 0
//         ProteinDetectionList.Name                       = name
//         ProteinDetectionList.ProteinAmbiguityGroups     = proteinAmbiguityGroups
//         ProteinDetectionList.RowVersion                 = DateTime.Now.Date
//         ProteinDetectionList.ProteinDetectionListParams = proteinDetectionListParams
//         ProteinDetectionList.UserParams                 = userParams
//        }

//    let createProteinDetectionListParam (*proteinDetectionList*) value term unit unitName =
//        {
//         ProteinDetectionListParam.ID               = 0
//         //ProteinDetectionListParam.//FKParamContainer  = proteinDetectionList
//         ProteinDetectionListParam.Value            = value
//         ProteinDetectionListParam.Term             = term
//         ProteinDetectionListParam.Unit             = unit
//         ProteinDetectionListParam.UnitName         = unitName
//         ProteinDetectionListParam.RowVersion       = DateTime.Now.Date
//        }

//    let createProteinDetectionProtocol name analysisSoftware analysisParams threshold =
//        {
//         ProteinDetectionProtocol.ID                             = 0
//         ProteinDetectionProtocol.Name                           = name
//         ProteinDetectionProtocol.AnalysisSoftwareRef            = analysisSoftware
//         ProteinDetectionProtocol.AnalysisParams                 = analysisParams
//         ProteinDetectionProtocol.Threshold                      = threshold
//         ProteinDetectionProtocol.RowVersion                     = DateTime.Now.Date
//         //ProteinDetectionProtocol.ProteinDetectionProtocolParams = proteinDetectionProtocolParams
//        }

//    //let createProteinDetectionProtocolParam proteinDetectionProtocol value term unit =
//    //    {
//    //     ProteinDetectionProtocolParam.ID               = 0
//    //     ProteinDetectionProtocolParam.//FKParamContainer  = proteinDetectionProtocol
//    //     ProteinDetectionProtocolParam.Value            = value
//    //     ProteinDetectionProtocolParam.Term             = term
//    //     ProteinDetectionProtocolParam.Unit             = unit
//    //     ProteinDetectionProtocolParam.RowVersion       = DateTime.Now.Date
//    //    }

//    let createProvider name contactRole analysisSoftwareRef =
//        {
//         Provider.ID                  = 0
//         Provider.Name                = name
//         Provider.ContactRole         = contactRole
//         Provider.AnalysisSoftwareRef = analysisSoftwareRef 
//         Provider.RowVersion          = DateTime.Now.Date
//        }

//    let createResidue sequence mass =
//        {
//         Residue.ID         = 0
//         Residue.Sequence   = sequence
//         Residue.Mass       = mass
//         Residue.RowVersion = DateTime.Now.Date
//        }

//    let createRoleParam (*proteinDetectionList*) value term unit unitName =
//        {
//         RoleParam.ID               = 0
//         //ProteinDetectionListParam.//FKParamContainer  = proteinDetectionList
//         RoleParam.Value            = value
//         RoleParam.Term             = term
//         RoleParam.Unit             = unit
//         RoleParam.UnitName         = unitName
//         RoleParam.RowVersion       = DateTime.Now.Date
//        }

//    let createRole roleParams =
//        {
//         Role.ID         = 0
//         //Role.Name       = name
//         Role.RowVersion = DateTime.Now.Date
//         Role.RoleParams = roleParams
//        }

//    let createSample name contactRoles subSample sampleParams userParams =
//        {
//         Sample.ID           = 0
//         Sample.Name         = name
//         Sample.ContactRoles = contactRoles
//         Sample.SubSample    = subSample
//         Sample.RowVersion   = DateTime.Now.Date
//         Sample.SampleParams = sampleParams
//         Sample.UserParams   = userParams
//        }

//    let createSampleParam (*sample*) value term unit unitName =
//        {
//         SampleParam.ID               = 0
//         //SampleParam.//FKParamContainer  = sample
//         SampleParam.Value            = value
//         SampleParam.Term             = term
//         SampleParam.Unit             = unit
//         SampleParam.UnitName         = unitName
//         SampleParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSearchDatabase name location numResidues numDatabaseSequences releaseDate version externalFormatDocumentation fileFormat dataBaseName searchDatabaseParams =
//        {
//         SearchDatabase.ID                          = 0
//         SearchDatabase.Name                        = name
//         SearchDatabase.Location                    = location
//         SearchDatabase.NumResidues                 = numResidues
//         SearchDatabase.NumDatabaseSequences        = numDatabaseSequences
//         SearchDatabase.ReleaseDate                 = releaseDate
//         SearchDatabase.Version                     = version
//         SearchDatabase.ExternalFormatDocumentation = externalFormatDocumentation
//         SearchDatabase.FileFormat                  = fileFormat
//         SearchDatabase.DatabaseName                = dataBaseName
//         SearchDatabase.RowVersion                  = DateTime.Now.Date
//         SearchDatabase.SearchDatabaseParams        = searchDatabaseParams
//        }

//    let createSearchDatabaseParam (*searchDatabase*) value term unit unitName =
//        {
//         SearchDatabaseParam.ID               = 0
//         //SearchDatabaseParam.//FKParamContainer  = searchDatabase
//         SearchDatabaseParam.Value            = value
//         SearchDatabaseParam.Term             = term
//         SearchDatabaseParam.Unit             = unit
//         SearchDatabaseParam.UnitName         = unitName
//         SearchDatabaseParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSearchDatabaseRef searchDatabase =
//        {
//         SearchDatabaseRef.ID             = 0
//         SearchDatabaseRef.SearchDatabase = searchDatabase 
//         SearchDatabaseRef.RowVersion     = DateTime.Now.Date
//        }

//    let createSearchModificationParam (*searchDatabase*) value term unit unitName =
//        {
//         SearchModificationParam.ID               = 0
//         //SearchModificationParam.//FKParamContainer  = searchDatabase
//         SearchModificationParam.Value            = value
//         SearchModificationParam.Term             = term
//         SearchModificationParam.Unit             = unit
//         SearchModificationParam.UnitName         = unitName
//         SearchModificationParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSearchModification fixedMod massDelta residues specificityRules searchModificationParams =
//        {
//         SearchModification.ID                       = 0
//         SearchModification.FixedMod                 = fixedMod
//         SearchModification.MassDelta                = massDelta
//         SearchModification.Residues                 = residues
//         SearchModification.SpecificityRules         = specificityRules
//         SearchModification.RowVersion               = DateTime.Now.Date
//         SearchModification.SearchModificationParams = searchModificationParams
//        }

//    let createSearchTypeParam (*searchDatabase*) value term unit unitName =
//        {
//         SearchTypeParam.ID               = 0
//         //SearchTypeParam.//FKParamContainer  = searchDatabase
//         SearchTypeParam.Value            = value
//         SearchTypeParam.Term             = term
//         SearchTypeParam.Unit             = unit
//         SearchTypeParam.UnitName         = unitName
//         SearchTypeParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSearchType searchTypeParam userParam =
//        {
//         SearchType.ID              = 0
//         SearchType.SearchTypeParam = searchTypeParam
//         SearchType.UserParam       = userParam
//         SearchType.RowVersion      = DateTime.Now.Date
//        }

//    let createSeq sequence =
//        {
//         Seq.ID         = 0
//         Seq.Sequence   = sequence
//         Seq.RowVersion = DateTime.Now.Date
//        }

//    let createSequenceCollection peptides peptideEvidences dbSequences =
//        {
//         SequenceCollection.ID              = 0
//         SequenceCollection.Peptides         = peptides
//         SequenceCollection.PeptideEvidences = peptideEvidences
//         SequenceCollection.DBSequences      = dbSequences
//         SequenceCollection.RowVersion      = DateTime.Now.Date
//        }

//    let createSiteRegexp sequence =
//        {
//         SiteRegexp.ID         = 0
//         SiteRegexp.Sequence   = sequence
//         SiteRegexp.RowVersion = DateTime.Now.Date
//        }

//    let createSoftwareNameParam (*searchDatabase*) value term unit unitName =
//        {
//         SoftwareNameParam.ID               = 0
//         //SpecificityRulesParam.//FKParamContainer  = searchDatabase
//         SoftwareNameParam.Value            = value
//         SoftwareNameParam.Term             = term
//         SoftwareNameParam.Unit             = unit
//         SoftwareNameParam.UnitName         = unitName
//         SoftwareNameParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSoftwareName softwareNameParam userparam =
//        {
//         SoftwareName.ID                = 0
//         //SoftwareName.Name              = name
//         SoftwareName.SoftwareNameParam = softwareNameParam
//         SoftwareName.UserParam         = userparam
//         SoftwareName.RowVersion        = DateTime.Now.Date
//        }

//    let createSourceFileParam (*searchDatabase*) value term unit unitName =
//        {
//         SourceFileParam.ID               = 0
//         //SpecificityRulesParam.//FKParamContainer  = searchDatabase
//         SourceFileParam.Value            = value
//         SourceFileParam.Term             = term
//         SourceFileParam.Unit             = unit
//         SourceFileParam.UnitName         = unitName
//         SourceFileParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSourceFile name location fileFormat externalFormatDocumentation sourceFileParams userParams =
//        {
//         SourceFile.ID                          = 0
//         SourceFile.Name                        = name
//         SourceFile.Location                    = location
//         SourceFile.FileFormat                  = fileFormat
//         SourceFile.ExternalFormatDocumentation = externalFormatDocumentation
//         SourceFile.RowVersion                  = DateTime.Now.Date
//         SourceFile.SourceFileParams            = sourceFileParams
//         SourceFile.UserParams                  = userParams
//        }

//    let createSpecificityRulesParam (*searchDatabase*) value term unit unitName =
//        {
//         SpecificityRulesParam.ID               = 0
//         //SpecificityRulesParam.//FKParamContainer  = searchDatabase
//         SpecificityRulesParam.Value            = value
//         SpecificityRulesParam.Term             = term
//         SpecificityRulesParam.Unit             = unit
//         SpecificityRulesParam.UnitName         = unitName
//         SpecificityRulesParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSpecificityRules terms =
//        {
//         SpecificityRules.ID         = 0
//         SpecificityRules.Terms      = terms
//         SpecificityRules.RowVersion = DateTime.Now.Date
//        }

//    let createSpectraData name location fileFormat externalFormatDocumentation spectrumIDFormat =
//        {
//         SpectraData.ID                          = 0
//         SpectraData.Name                        = name
//         SpectraData.Location                    = location
//         SpectraData.FileFormat                  = fileFormat
//         SpectraData.ExternalFormatDocumentation = externalFormatDocumentation
//         SpectraData.SpectrumIDFormat            = spectrumIDFormat
//         SpectraData.RowVersion                  = DateTime.Now.Date
//         //SpectraData.SpectraDataParams = spectraDataParams
//        }

//    //let createSpectraDataParam spectraData value term unit =
//    //    {
//    //     SpectraDataParam.ID               = 0
//    //     SpectraDataParam.//FKParamContainer  = spectraData
//    //     SpectraDataParam.Value            = value
//    //     SpectraDataParam.Term             = term
//    //     SpectraDataParam.Unit             = unit
//    //     SpectraDataParam.RowVersion       = DateTime.Now.Date
//    //    }

//    let createSpectrumIdentification name activityDate spectrumIdentificationListRef spectrumIdentificationProtocolRef inputSpectras searchDatabaseRefs =
//        {
//         SpectrumIdentification.ID                                 = 0
//         SpectrumIdentification.Name                               = name
//         SpectrumIdentification.ActivityDate                       = activityDate
//         SpectrumIdentification.SpectrumIdentificationListRef      = spectrumIdentificationListRef
//         SpectrumIdentification.SpectrumIdentificationProtocolRef  = spectrumIdentificationProtocolRef
//         SpectrumIdentification.InputSpectras                      = inputSpectras
//         SpectrumIdentification.SearchDatabaseRefs                 = searchDatabaseRefs
//         SpectrumIdentification.RowVersion                         = DateTime.Now.Date
//         //SpectrumIdentification.SpectrumIdentificationParams    = spectrumIdentificationParams
//        }

//    //let createSpectrumIdentificationParam spectrumIdentification value term unit =
//    //    {
//    //     SpectrumIdentificationParam.ID               = 0
//    //     SpectrumIdentificationParam.//FKParamContainer  = spectrumIdentification
//    //     SpectrumIdentificationParam.Value            = value
//    //     SpectrumIdentificationParam.Term             = term
//    //     SpectrumIdentificationParam.Unit             = unit
//    //     SpectrumIdentificationParam.RowVersion       = DateTime.Now.Date
//    //    }

//    let createSpectrumIdentificationItem name peptideRef chargeState sampleRef passThreshold fragmentation rank massTableRef calculatedIP calculatedMassToCharge experimentalMassToCharge peptideEvidenceRef spectrumIdentificationItemParams userParams =
//        {
//         SpectrumIdentificationItem.ID                               = 0
//         SpectrumIdentificationItem.Name                             = name
//         SpectrumIdentificationItem.ChargeState                      = chargeState
//         SpectrumIdentificationItem.SampleRef                        = sampleRef
//         SpectrumIdentificationItem.PassThreshold                    = passThreshold
//         SpectrumIdentificationItem.Fragmentation                    = fragmentation
//         SpectrumIdentificationItem.Rank                             = rank
//         SpectrumIdentificationItem.MassTableRef                     = massTableRef
//         SpectrumIdentificationItem.CalculatedPI                     = calculatedIP
//         SpectrumIdentificationItem.CalculatedMassToCharge           = calculatedMassToCharge
//         SpectrumIdentificationItem.ExperimentalMassToCharge         = experimentalMassToCharge
//         SpectrumIdentificationItem.PeptideRef                       = peptideRef
//         SpectrumIdentificationItem.PeptideEvidenceRefs              = peptideEvidenceRef
//         SpectrumIdentificationItem.RowVersion                       = DateTime.Now.Date
//         SpectrumIdentificationItem.SpectrumIdentificationItemParams = spectrumIdentificationItemParams
//         SpectrumIdentificationItem.UserParams                       = userParams
//        }

//    let createSpectrumIdentificationItemParam (*spectrumIdentificationItem*) value term unit unitName =
//        {
//         SpectrumIdentificationItemParam.ID               = 0
//         //SpectrumIdentificationItemParam.//FKParamContainer  = spectrumIdentificationItem
//         SpectrumIdentificationItemParam.Value            = value
//         SpectrumIdentificationItemParam.Term             = term
//         SpectrumIdentificationItemParam.Unit             = unit
//         SpectrumIdentificationItemParam.UnitName         = unitName
//         SpectrumIdentificationItemParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSpectrumIdentificationItemRef spectrumIdentificationItemRef =
//        {
//         SpectrumIdentificationItemRef.ID                        = 0
//         SpectrumIdentificationItemRef.SpectrumIdentificationRef = spectrumIdentificationItemRef
//         SpectrumIdentificationItemRef.RowVersion                = DateTime.Now.Date
//        }

//    let createSpectrumIdentificationList name numSequencesSearched fragmentationTable spectrumIdentificationResult spectrumIdentificationListParams userParams =
//        {
//         SpectrumIdentificationList.ID                               = 0
//         SpectrumIdentificationList.Name                             = name
//         SpectrumIdentificationList.NumSequencesSearched             = numSequencesSearched
//         SpectrumIdentificationList.FragmentationTable               = fragmentationTable
//         SpectrumIdentificationList.SpectrumIdentificationResults    = spectrumIdentificationResult
//         SpectrumIdentificationList.RowVersion                       = DateTime.Now.Date
//         SpectrumIdentificationList.SpectrumIdentificationListParams = spectrumIdentificationListParams
//         SpectrumIdentificationList.UserParams                       = userParams
//        }

//    let createSpectrumIdentificationListParam (*spectrumIdentificationList*) value term unit unitName =
//        {
//         SpectrumIdentificationListParam.ID               = 0
//         //SpectrumIdentificationListParam.//FKParamContainer  = spectrumIdentificationList
//         SpectrumIdentificationListParam.Value            = value
//         SpectrumIdentificationListParam.Term             = term
//         SpectrumIdentificationListParam.Unit             = unit
//         SpectrumIdentificationListParam.UnitName         = unitName
//         SpectrumIdentificationListParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSpectrumIdentificationProtocol name analysisSoftwareRef searchType additionalSearchparams modificationParams enzymes massTables fragmentTolerance parentTolerance databaseFilters frame databaseTranslation threshold =
//        {
//         SpectrumIdentificationProtocol.ID                     = 0
//         SpectrumIdentificationProtocol.Name                   = name
//         SpectrumIdentificationProtocol.AnalysisSoftwareRef    = analysisSoftwareRef
//         SpectrumIdentificationProtocol.SearchType             = searchType
//         SpectrumIdentificationProtocol.AdditionalSearchparams = additionalSearchparams
//         SpectrumIdentificationProtocol.ModificationParams     = modificationParams
//         SpectrumIdentificationProtocol.Enzymes                = enzymes
//         SpectrumIdentificationProtocol.MassTables             = massTables
//         SpectrumIdentificationProtocol.FragmentTolerance      = fragmentTolerance
//         SpectrumIdentificationProtocol.ParentTolerance        = parentTolerance
//         SpectrumIdentificationProtocol.DatabaseFilters        = databaseFilters
//         SpectrumIdentificationProtocol.Frame                  = frame
//         SpectrumIdentificationProtocol.DatabaseTranslation    = databaseTranslation
//         SpectrumIdentificationProtocol.Threshold              = threshold
//         SpectrumIdentificationProtocol.RowVersion             = DateTime.Now.Date
//         //SpectrumIdentificationProtocol.SpectrumIdentificationProtocolParams = spectrumIdentificationProtocolParams
//        }

//    //let createSpectrumIdentificationProtocolParam spectrumIdentificationProtocol value term unit =
//    //    {
//    //     SpectrumIdentificationProtocolParam.ID               = 0
//    //     SpectrumIdentificationProtocolParam.//FKParamContainer  = spectrumIdentificationProtocol
//    //     SpectrumIdentificationProtocolParam.Value            = value
//    //     SpectrumIdentificationProtocolParam.Term             = term
//    //     SpectrumIdentificationProtocolParam.Unit             = unit
//    //     SpectrumIdentificationProtocolParam.RowVersion       = DateTime.Now.Date
//    //    }

//    let createSpectrumIdentificationResult name spectrumID spectraDataRef spectrumIdentificationitems spectrumIdentificationResultParams userParams =
//        {
//         SpectrumIdentificationResult.ID                                 = 0
//         SpectrumIdentificationResult.Name                               = name
//         SpectrumIdentificationResult.SpectrumID                         = spectrumID
//         SpectrumIdentificationResult.SpectraDataRef                     = spectraDataRef
//         SpectrumIdentificationResult.SpectrumIdentificationItems        = spectrumIdentificationitems
//         SpectrumIdentificationResult.RowVersion                         = DateTime.Now.Date
//         SpectrumIdentificationResult.SpectrumIdentificationResultParams = spectrumIdentificationResultParams
//         SpectrumIdentificationResult.UserParams                         = userParams
//        }

//    let createSpectrumIdentificationResultParam (*spectrumIdentificationResult*) value term unit unitName =
//        {
//         SpectrumIdentificationResultParam.ID               = 0
//         //SpectrumIdentificationResultParam.//FKParamContainer  = spectrumIdentificationResult
//         SpectrumIdentificationResultParam.Value            = value
//         SpectrumIdentificationResultParam.Term             = term
//         SpectrumIdentificationResultParam.Unit             = unit
//         SpectrumIdentificationResultParam.UnitName         = unitName
//         SpectrumIdentificationResultParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSpectrumIDFormatParam (*spectrumIdentificationResult*) value term unit unitName =
//        {
//         SpectrumIDFormatParam.ID               = 0
//         //SpectrumIdentificationResultParam.//FKParamContainer  = spectrumIdentificationResult
//         SpectrumIDFormatParam.Value            = value
//         SpectrumIDFormatParam.Term             = term
//         SpectrumIDFormatParam.Unit             = unit
//         SpectrumIDFormatParam.UnitName         = unitName
//         SpectrumIDFormatParam.RowVersion       = DateTime.Now.Date
//        }

//    let createSpectrumIDFormat spectrumIDFormatParam =
//        {
//         SpectrumIDFormat.ID                    = 0
//         SpectrumIDFormat.SpectrumIDFormatParam = spectrumIDFormatParam
//         SpectrumIDFormat.RowVersion            = DateTime.Now.Date
//        }

//    let createSubSample sampleRef =
//        {
//         SubSample.ID         = 0
//         SubSample.SampleRef  = sampleRef
//         SubSample.RowVersion = DateTime.Now.Date
//        }

//    let createSubstitutionModification monoIsotopicMassDelta avgMassDelta location orgResidue repResidue =
//        {
//         SubstitutionModification.ID                    = 0
//         SubstitutionModification.Location              = location
//         SubstitutionModification.AvgMassDelta          = avgMassDelta
//         SubstitutionModification.MonoIsotopicMassDelta = monoIsotopicMassDelta
//         SubstitutionModification.OriginalResidue       = orgResidue
//         SubstitutionModification.ReplacementResidue    = repResidue
//         SubstitutionModification.RowVersion            = DateTime.Now.Date
//        }

//    let createTerm (oboTerm : seq<Obo.OboTerm>) =
//        new System
//            .Collections
//            .Generic
//            .List<Term>(
//            oboTerm
//                |> Seq.map (fun item ->
//                                        {
//                                         Term.ID         = item.Id
//                                         Term.Name       = item.Name
//                                         //Term.Ontology   = ontology
//                                         Term.RowVersion = DateTime.Now.Date
//                                        }
//                           )   
//                       )

//    let createTermCustom id name =
//        {
//         Term.ID         = id
//         Term.Name       = name
//         //Term.Ontology   = ontology
//         Term.RowVersion = DateTime.Now.Date
//        }

//    let createTermRelationship term relationshipType relatedTerm =
//        {
//         TermRelationShip.ID               = 0
//         TermRelationShip.Term             = term
//         TermRelationShip.RelationShipType = relationshipType
//         TermRelationShip.RelatedTerm      = relatedTerm
//         TermRelationShip.RowVersion       = DateTime.Now.Date
//        }

//    let createTermTag name value term =
//        {
//         TermTag.ID         = 0
//         TermTag.Name       = name
//         TermTag.Value      = value
//         TermTag.Term       = term
//         TermTag.RowVersion = DateTime.Now.Date
//        }

//    let createThresholdParam value term unit unitName =
//        {
//         ThresholdParam.ID               = 0
//         //ThresholdParam.//FKParamContainer  = spectrumIdentificationResult
//         ThresholdParam.Value            = value
//         ThresholdParam.Term             = term
//         ThresholdParam.Unit             = unit
//         ThresholdParam.UnitName         = unitName
//         ThresholdParam.RowVersion       = DateTime.Now.Date
//        }

//    let createThreshold terms userParams =
//        {
//         Threshold.ID              = 0
//         Threshold.ThresholdParams = terms
//         Threshold.UserParams      = userParams
//         Threshold.RowVersion      = DateTime.Now.Date
//        }

//    let createTranslationTableParam value term unit unitName =
//        {
//         TranslationTableParam.ID               = 0
//         //ThresholdParam.//FKParamContainer  = spectrumIdentificationResult
//         TranslationTableParam.Value            = value
//         TranslationTableParam.Term             = term
//         TranslationTableParam.Unit             = unit
//         TranslationTableParam.UnitName         = unitName
//         TranslationTableParam.RowVersion       = DateTime.Now.Date
//        }

//    let createTranslationTable name translationTableParamms =
//        {
//         TranslationTable.ID                     = 0
//         TranslationTable.Name                   = name
//         TranslationTable.RowVersion             = DateTime.Now.Date
//         TranslationTable.TranslationTableParams = translationTableParamms
//        }

//    let createUserParam value types term unit unitName unitAccession =
//        {
//         UserParam.ID            = 0
//         UserParam.Value         = value
//         UserParam.Type          = types
//         UserParam.Term          = term
//         UserParam.Unit          = unit
//         UserParam.UnitName      = unitName
//         UserParam.Name          = unitAccession
//         UserParam.RowVersion    = DateTime.Now.Date
//        }

//module InitializationOfDB =

//    open Entities.BasicTypesOfEntities
//    open Entities.DBContext
//    open InsertStatements

//    //Defining funtions to create Ontologies

//    let fromFileObo (filePath : string) =
//        FileIO.readFile filePath
//        |> Obo.parseOboTerms

//    let fromPsiMS =
//        fromFileObo (fileDir + "\Ontologies_Terms\Psi-MS.txt")

//    let fromPride =
//        fromFileObo (fileDir + "\Ontologies_Terms\Pride.txt")

//    let fromUniMod =
//        fromFileObo (fileDir + "\Ontologies_Terms\Unimod.txt")

//    let fromUnit_Ontology =
//        fromFileObo (fileDir + "\Ontologies_Terms\Unit_Ontology.txt")

//    //Applying funtions to create Ontologies

//    let ontologyCustom =
//         createOntology "Custom" null (new System.Collections.Generic.List<Term>([createTermCustom "000000" "Unitless"]))

//    let ontologyPsiMS =
//        createOntology "Psi-MS" null (createTerm fromPsiMS)

//    let ontologyPride =
//        createOntology "Pride" null (createTerm fromPride)

//    let ontologyUniMod =
//        createOntology "UniMod" null (createTerm fromUniMod)

//    let ontologyUnit_Ontology =
//        createOntology "Unit_Ontology" null (createTerm fromUnit_Ontology)

//    //Inserting information into DB

//    let initDB path = 

//        let db = (configureSQLiteServerContext path)
    
//        db.Database.EnsureCreated()                                     |> ignore

//        [ontologyCustom; ontologyPsiMS; ontologyPride; ontologyUniMod; ontologyUnit_Ontology]
//        |> List.map (fun item -> db.Add(item) )                         |> ignore
//        db.SaveChanges()


////module test =
////    //Define InsertStatements////////////////////////////////////////////////////////////////////////////////////////
////    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

////    let convertToEntityUserParams (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.UserParam []) =   
////        mzIdentMLXML
////            |> Array.map (fun userParamItem -> (createUserParam (if userParamItem.Value.IsSome 
////                                                                    then userParamItem.Value.Value 
////                                                                    else null)
////                                                                (if userParamItem.Type.IsSome 
////                                                                    then userParamItem.Type.Value 
////                                                                    else null)
////                                                                (if userParamItem.UnitCvRef.IsSome 
////                                                                    then takeTermID dbContext userParamItem.UnitCvRef.Value
////                                                                    else null)
////                                                                (if userParamItem.UnitAccession.IsSome 
////                                                                    then takeTermID dbContext userParamItem.UnitAccession.Value
////                                                                    else null)
////                                                                (if userParamItem.UnitName.IsSome 
////                                                                    then userParamItem.UnitName.Value 
////                                                                    else null)
////                                                                userParamItem.Name
////                                               )
////                         ) |> List

////    let convertToEntityUserParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.UserParam option) =   
////        if mzIdentMLXML.IsSome
////           then mzIdentMLXML.Value
////                |> (fun userParamItem -> (createUserParam (if userParamItem.Value.IsSome 
////                                                              then userParamItem.Value.Value 
////                                                              else null)
////                                                          (if userParamItem.Type.IsSome 
////                                                              then userParamItem.Type.Value 
////                                                              else null)
////                                                          (if userParamItem.UnitCvRef.IsSome 
////                                                              then takeTermID dbContext userParamItem.UnitCvRef.Value
////                                                              else null)
////                                                          (if userParamItem.UnitAccession.IsSome 
////                                                              then takeTermID dbContext userParamItem.UnitAccession.Value
////                                                              else null)
////                                                          (if userParamItem.UnitName.IsSome 
////                                                              then userParamItem.UnitName.Value 
////                                                              else null)
////                                                          userParamItem.Name
////                                     )
////               )
////           else createUserParam null null null null null null

////    let convertToEntityCVs (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =  
////        mzIdentMLXML.CvList
////            |> Array.map (fun cvItem -> (createCV  cvItem.FullName
////                                                   cvItem.Uri
////                                                   (if cvItem.Version.IsSome 
////                                                      then cvItem.Version.Value 
////                                                      else null
////                                                   )
                                              
////                                        )
////                          ) |> List
  
////    let convertToEntityCVList (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =   
////        createCVList (convertToEntityCVs mzIdentMLXML)

////    let convertToEntityInputSpectrumIdentifications (mzIdentMLXML : SchemePeptideShaker.InputSpectrumIdentifications []) =
////        mzIdentMLXML
////            |> Array.map (fun inputSpectrumIdentificationsItem -> createInputSpectrumIdentification inputSpectrumIdentificationsItem.SpectrumIdentificationListRef) |> List

////    let convertToEntityProteinDetection  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.ProteinDetection option) =
////        if mzIdentMLXML.IsSome
////            then mzIdentMLXML.Value 
////                |> (fun proteinDetectionItem -> (createProteinDetection proteinDetectionItem.Id 
////                                                                        //(if proteinDetectionItem.Name.IsSome then proteinDetectionItem.Name.Value else null) 
////                                                                        proteinDetectionItem.ProteinDetectionProtocolRef
////                                                                        proteinDetectionItem.ProteinDetectionListRef
////                                                                        (proteinDetectionItem.InputSpectrumIdentifications 
////                                                                            |> convertToEntityInputSpectrumIdentifications
////                                                                        )
////                                                                        (if proteinDetectionItem.ActivityDate.IsSome 
////                                                                            then proteinDetectionItem.ActivityDate.Value 
////                                                                            else DateTime.UtcNow)))
////            else createProteinDetection null null null null DateTime.UtcNow

////    let convertToEntityInputSpectras (mzIdentMLXML : SchemePeptideShaker.InputSpectra []) =
////        mzIdentMLXML
////            |> Array.map (fun inputSpectraItem -> createInputSpectra (if inputSpectraItem.SpectraDataRef.IsSome 
////                                                                         then inputSpectraItem.SpectraDataRef.Value 
////                                                                         else null)) |> List

////    let convertToEntitySearchDatabaseRef (mzIdentMLXML : SchemePeptideShaker.SearchDatabaseRef []) =  
////        mzIdentMLXML
////            |> Array.map (fun searchDatabaseRefItem -> createSearchDatabaseRef (if searchDatabaseRefItem.SearchDatabaseRef.IsSome 
////                                                                                   then searchDatabaseRefItem.SearchDatabaseRef.Value 
////                                                                                   else null)) |> List

////    let convertToEntitySpectrumIdentifications (mzIdentMLXML : SchemePeptideShaker.SpectrumIdentification []) =
////        mzIdentMLXML
////        |> Array.map (fun spectrumIdentificationItem -> createSpectrumIdentification  spectrumIdentificationItem.Id
////                                                                                      (if spectrumIdentificationItem.ActivityDate.IsSome 
////                                                                                        then spectrumIdentificationItem.ActivityDate.Value 
////                                                                                        else DateTime.UtcNow)
////                                                                                      //(if spectrumIdentificationItem.Name.IsSome then spectrumIdentificationItem.Name.Value else null)
////                                                                                      spectrumIdentificationItem.SpectrumIdentificationListRef
////                                                                                      spectrumIdentificationItem.SpectrumIdentificationProtocolRef 
////                                                                                      (spectrumIdentificationItem.InputSpectras
////                                                                                       |> convertToEntityInputSpectras)
////                                                                                      (spectrumIdentificationItem.SearchDatabaseRefs
////                                                                                        |> convertToEntitySearchDatabaseRef
////                                                                                      )
////                     ) |> List

////    let convertToEntityAnalysisParamsCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createAnalysisParamsParam (*cvParamItem.Name*)
////                                                                        //cvParamItem.Accession 
////                                                                        (if cvParamItem.Value.IsSome 
////                                                                            then cvParamItem.Value.Value 
////                                                                            else null)
////                                                                        (takeTermID dbContext cvParamItem.CvRef)
////                                                                        //(if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
////                                                                        (if cvParamItem.UnitCvRef.IsSome 
////                                                                            then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                            else null)
////                                                                        //(if cvParamItem.UnitAccession.IsSome then cvParamItem.UnitAccession.Value else null)
////                                             )
////                         ) |> List

////    let convertToEntityAnalysisParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.AnalysisParams option) = 
////        (if mzIdentMLXML.IsSome 
////            then (createAnalysisParams (convertToEntityAnalysisParamsCVParams dbContext mzIdentMLXML.Value.CvParams) 
////                                       (convertToEntityUserParams dbContext mzIdentMLXML.Value.UserParams)
////                 )
////            else createAnalysisParams null null
////        )
                                                    

////    let convertToEntityThresholdOfProteinDetectionCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createThresholdParam  (*cvParamItem.Name*)
////                                                                    //cvParamItem.Accession 
////                                                                    (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                    (takeTermID dbContext cvParamItem.CvRef)
////                                                                    (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                    (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
////                                              )
////                         ) |> List


////    let convertToEntityThresholdOfProteinDetection  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Threshold) =  
////        mzIdentMLXML
////            |> (fun thresholdItem -> (createThreshold  (convertToEntityThresholdOfProteinDetectionCVParams dbContext thresholdItem.CvParams) 
////                                                       (convertToEntityUserParams dbContext thresholdItem.UserParams)
////                                     )
////               )

////    let convertToEntityAdditionalSearchParamsCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =   
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createAdditionalSearchParamsParam (*cvParamItem.Name*)
////                                                                               //cvParamItem.Accession 
////                                                                               (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                               (takeTermID dbContext cvParamItem.CvRef)
////                                                                               (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                               (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
////                         ) |> List

////    let convertToEntityAdditionalSearchParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.AdditionalSearchParams option) =
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value 
////                |> (fun additionalSearchParamItem -> createAdditionalSearchParams (convertToEntityAdditionalSearchParamsCVParams dbContext additionalSearchParamItem.CvParams
////                                                                                  )
////                                                                                  (convertToEntityUserParams dbContext additionalSearchParamItem.UserParams
////                                                                                  )
////                   )
////            else createAdditionalSearchParams null null

////    let convertToEntitySearchTypeCVParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam option) =
////         if mzIdentMLXML.IsSome
////            then mzIdentMLXML.Value
////                 |> (fun cvParamItem -> (createSearchTypeParam (*cvParamItem.Name*)
////                                                               //cvParamItem.Accession 
////                                                               (if cvParamItem.Value.IsSome 
////                                                                   then cvParamItem.Value.Value 
////                                                                   else null)
////                                                               (takeTermID dbContext cvParamItem.CvRef)
////                                                               (if cvParamItem.UnitCvRef.IsSome 
////                                                                   then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                   else null)
////                                                               (if cvParamItem.UnitName.IsSome 
////                                                                   then cvParamItem.UnitName.Value 
////                                                                   else null)
////                                        )
////                    )
////            else createSearchTypeParam null null null null

////    let convertToEntitySearchType  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SearchType) =
////        mzIdentMLXML
////            |> (fun searchTypeItem -> createSearchType (convertToEntitySearchTypeCVParam dbContext searchTypeItem.CvParam
////                                                       )
////                                                       (convertToEntityUserParam dbContext searchTypeItem.UserParam
////                                                       )                                                                                                                                                                                                                
////               )

////    let convertToEntitySpecificityRulesCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createSpecificityRulesParam (*cvParamItem.Name*)
////                                                                          //cvParamItem.Accession 
////                                                                          (if cvParamItem.Value.IsSome 
////                                                                              then cvParamItem.Value.Value 
////                                                                              else null)
////                                                                          (takeTermID dbContext cvParamItem.CvRef)
////                                                                          (if cvParamItem.UnitCvRef.IsSome 
////                                                                              then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                              else null)
////                                                                          (if cvParamItem.UnitName.IsSome 
////                                                                              then cvParamItem.UnitName.Value 
////                                                                              else null)
                                                                                                                                                                                        
////                                             )
////                         ) |> List

////    let convertToEntitySpecificityRules  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SpecificityRules []) =
////        mzIdentMLXML
////            |> Array.map (fun specificityRuleItem -> createSpecificityRules (convertToEntitySpecificityRulesCVParams dbContext specificityRuleItem.CvParams)
////                         ) |> List

////    let convertToEntitySearchModificationsCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createSearchModificationParam (*cvParamItem.Name*)
////                                                                            //cvParamItem.Accession 
////                                                                            (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                            (takeTermID dbContext cvParamItem.CvRef)
////                                                                            (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                            (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
                                                                                                                                                                                        
////                                             )
////                         ) |> List

////    let convertToEntitySearchModifications  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SearchModification []) =
////        mzIdentMLXML
////            |> Array.map (fun searchModificationItem -> createSearchModification    searchModificationItem.FixedMod
////                                                                                    searchModificationItem.MassDelta 
////                                                                                    searchModificationItem.Residues 
////                                                                                    (convertToEntitySpecificityRules dbContext searchModificationItem.SpecificityRules
////                                                                                    )
////                                                                                    (convertToEntitySearchModificationsCVParams dbContext searchModificationItem.CvParams
////                                                                                    )
                                                                                                                                                                                
////                         ) |> List

////    let convertToEntityModificationParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.ModificationParams option) =
////        if mzIdentMLXML.IsSome 
////            then mzIdentMLXML.Value
////                 |> (fun modificationParamItem -> (createModificationParams (convertToEntitySearchModifications dbContext modificationParamItem.SearchModifications))
////                    )
////            else createModificationParams null


////    let convertToEntityEnzymeNameCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createEnzymeNameParam (*cvParamItem.Name*)
////                                                                    //cvParamItem.Accession 
////                                                                    (if cvParamItem.Value.IsSome 
////                                                                        then cvParamItem.Value.Value 
////                                                                        else null
////                                                                    )
////                                                                    (takeTermID dbContext cvParamItem.CvRef)
////                                                                    (if cvParamItem.UnitCvRef.IsSome 
////                                                                        then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                        else null
////                                                                    )
////                                                                    (if cvParamItem.UnitName.IsSome 
////                                                                        then cvParamItem.UnitName.Value 
////                                                                        else null
////                                                                    )
                                                                                                                                                                                       
////                                             )
////                         ) |> List

////    let convertToEntityEnzymeName  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.EnzymeName option) =
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value 
////                |> (fun enzymeNameItem -> (createEnzymeName (convertToEntityEnzymeNameCVParams dbContext enzymeNameItem.CvParams
////                                                            )
////                                                            (convertToEntityUserParams dbContext enzymeNameItem.UserParams
////                                                            )
////                                          )
////                   )
////            else createEnzymeName null null

////    let convertToEntityEnzyme  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Enzyme []) =   
////        mzIdentMLXML
////            |> Array.map (fun enzymeItem -> createEnzyme enzymeItem.Id 
////                                                            //(if enzymeItem.Name.IsSome then enzymeItem.Name.Value else null) 
////                                                            (if enzymeItem.CTermGain.IsSome 
////                                                                then enzymeItem.CTermGain.Value 
////                                                                else null
////                                                            )
////                                                            (if enzymeItem.NTermGain.IsSome 
////                                                                then enzymeItem.NTermGain.Value 
////                                                                else null
////                                                            ) 
////                                                            (if enzymeItem.MinDistance.IsSome 
////                                                                then enzymeItem.MinDistance.Value 
////                                                                else -1
////                                                            )
////                                                            (if enzymeItem.MissedCleavages.IsSome 
////                                                                then enzymeItem.MissedCleavages.Value.ToString()
////                                                                else null
////                                                            )
////                                                            (if enzymeItem.SemiSpecific.IsSome 
////                                                                then enzymeItem.SemiSpecific.Value.ToString()
////                                                                else null
////                                                            )
////                                                            (if enzymeItem.SiteRegexp.IsSome 
////                                                                then (createSiteRegexp enzymeItem.SiteRegexp.Value) 
////                                                                else  createSiteRegexp null
////                                                            )
////                                                            (convertToEntityEnzymeName dbContext enzymeItem.EnzymeName
////                                                            )
////                         ) |> List

////    let convertToEntityEnzymes  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Enzymes option) = 
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value
////                |> (fun enzymesItem -> createEnzymes (if enzymesItem.Independent.IsSome 
////                                                         then enzymesItem.Independent.Value.ToString() 
////                                                         else null
////                                                     )
////                                                     (convertToEntityEnzyme dbContext enzymesItem.Enzymes
////                                                     )
////                   )
////           else createEnzymes null null

////    let convertToEntityAmbiguousResiduesCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createAmbiguousResidueParam (*cvParamItem.Name*)
////                                                                          //cvParamItem.Accession 
////                                                                          (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                          (takeTermID dbContext cvParamItem.CvRef)
////                                                                          (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                          (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
                                                                                                                                                                                        
////                                             )
////                         ) |> List

////    let convertToEntityAmbiguousResidues  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.AmbiguousResidue []) =
////        mzIdentMLXML
////            |> Array.map (fun ambiguousResidueItem-> (createAmbiguousResidue ambiguousResidueItem.Code 
////                                                                             (convertToEntityAmbiguousResiduesCVParams dbContext ambiguousResidueItem.CvParams
////                                                                             )
////                                                                             (convertToEntityUserParams dbContext ambiguousResidueItem.UserParams
////                                                                             )
////                                                     ) 
////                         ) |> List

////    let convertToEntityResiduesOfMassTable (mzIdentMLXML : SchemePeptideShaker.Residue []) = 
////        mzIdentMLXML
////            |> Array.map (fun residueItem -> createResidue residueItem.Code 
////                                                           residueItem.Mass
////                         ) |> List

////    let massTablesCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createMassTableParam (*cvParamItem.Name*)
////                                                                   //cvParamItem.Accession 
////                                                                   (if cvParamItem.Value.IsSome 
////                                                                       then cvParamItem.Value.Value 
////                                                                       else null)
////                                                                   (takeTermID dbContext cvParamItem.CvRef)
////                                                                   (if cvParamItem.UnitCvRef.IsSome 
////                                                                       then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                       else null)
////                                                                   (if cvParamItem.UnitName.IsSome 
////                                                                       then cvParamItem.UnitName.Value 
////                                                                       else null)
                                                                                                                                                                                        
////                                             )
////                         ) |> List

////    let convertToEntityMassTables  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.MassTable []) =
////        mzIdentMLXML
////            |> Array.map (fun massTableItem -> createMassTable (massTableItem.Id) 
////                                                               //(if massTableItem.Name.IsSome then massTableItem.Name.Value else null)
////                                                               (massTableItem.MsLevel)
////                                                               (convertToEntityAmbiguousResidues dbContext massTableItem.AmbiguousResidues
////                                                               )
////                                                               (convertToEntityResiduesOfMassTable massTableItem.Residues
////                                                               )
////                                                               (massTablesCVParams dbContext massTableItem.CvParams
////                                                               )
////                                                               (convertToEntityUserParams dbContext massTableItem.UserParams
////                                                               )
                                                                                                
////                         ) |> List

////    let convertToEntityFragmentToleranceCVParams (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createFragmentToleranceParam (*cvParamItem.Name*)
////                                                                           //cvParamItem.Accession 
////                                                                           (if cvParamItem.Value.IsSome 
////                                                                               then cvParamItem.Value.Value 
////                                                                               else null
////                                                                           )
////                                                                           (takeTermID dbContext cvParamItem.CvRef)
////                                                                           (if cvParamItem.UnitCvRef.IsSome 
////                                                                               then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                               else null)
////                                                                           (if cvParamItem.UnitName.IsSome 
////                                                                               then cvParamItem.UnitName.Value 
////                                                                               else null
////                                                                           )
                                                                                                                                                                                        
////                                             )
////                         ) |> List

////    let convertToEntityFragmentTolerance (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.FragmentTolerance option) =
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value
////                |> (fun fragmentToleranceItem -> createFragmentTolerance (convertToEntityFragmentToleranceCVParams dbContext fragmentToleranceItem.CvParams)
////                   )
////           else createFragmentTolerance null

////    let convertToEntityExcludeCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =   
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createExcludeParam (*cvParamItem.Name*)
////                                                                 //cvParamItem.Accession 
////                                                                 (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                 (takeTermID dbContext cvParamItem.CvRef)
////                                                                 (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                 (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
////                                             )
////                         ) |> List

////    let convertToEntityExclude  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Exclude option) = 
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value
////                |> (fun excludeItem -> createExclude (convertToEntityExcludeCVParams dbContext excludeItem.CvParams)
////                                                     (convertToEntityUserParams dbContext excludeItem.UserParams) 
////                   )
////            else createExclude null null

////    let convertToEntityIncludeCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createIncludeParam (*cvParamItem.Name*)
////                                                                 //cvParamItem.Accession 
////                                                                 (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                 (takeTermID dbContext cvParamItem.CvRef)
////                                                                 (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                 (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
////                                             )
////                         ) |> List

////    let convertToEntityIncludes  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Include option) = 
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value
////                |> (fun includeItem -> createInclude (convertToEntityIncludeCVParams dbContext includeItem.CvParams)
////                                                     (convertToEntityUserParams dbContext includeItem.UserParams) 
////                   )
////            else createInclude null null

////    let convertToEntityFilterTypeCVParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam option) =
////        if mzIdentMLXML.IsSome
////           then mzIdentMLXML.Value
////                |> (fun cvParamItem -> (createFilterTypeParam (*cvParamItem.Name*)
////                                                                //cvParamItem.Accession 
////                                                                (if cvParamItem.Value.IsSome 
////                                                                    then cvParamItem.Value.Value 
////                                                                    else null)
////                                                                (takeTermID dbContext cvParamItem.CvRef)
////                                                                (if cvParamItem.UnitCvRef.IsSome 
////                                                                    then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                    else null)
////                                                                (if cvParamItem.UnitName.IsSome 
////                                                                    then cvParamItem.UnitName.Value 
////                                                                    else null)
////                                       )
////                   )
////            else createFilterTypeParam null null null null
        
////    let convertToEntityFilterType  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.FilterType) = 
////        mzIdentMLXML
////        |> (fun filterTypeItem -> createFilterType (convertToEntityFilterTypeCVParam dbContext filterTypeItem.CvParam
////                                                   ) 
////                                                   (convertToEntityUserParam dbContext filterTypeItem.UserParam
////                                                   )
////           )

////    let convertToEntityFilters  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Filter []) = 
////        mzIdentMLXML
////            |> Array.map (fun filterItem -> createFilter (convertToEntityFilterType dbContext filterItem.FilterType
////                                                         )
////                                                         (convertToEntityExclude dbContext filterItem.Exclude
////                                                         )
////                                                         (convertToEntityIncludes dbContext filterItem.Include
////                                                         )
////                         ) |> List

////    let convertToEntityDatabaseFilters  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.DatabaseFilters option) = 
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value
////                |> (fun databaseFilterItem -> createDatabaseFilters (convertToEntityFilters dbContext databaseFilterItem.Filters))
////           else createDatabaseFilters null

////    let convertToEntityTranslationTablesCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) = 
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createTranslationTableParam (*cvParamItem.Name*)
////                                                                          //cvParamItem.Accession 
////                                                                          (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                          (takeTermID dbContext cvParamItem.CvRef)
////                                                                          (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                          (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
                                                                                                                                                                                       
////                                             )
////                         ) |> List

////    let convertToEntityTranslationTables  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.TranslationTable []) =  
////        mzIdentMLXML
////            |> Array.map (fun translationTable -> createTranslationTable translationTable.Id
////                                                                         //(if translationTable.Name.IsSome then translationTable.Name.Value else null) 
////                                                                         (convertToEntityTranslationTablesCVParams dbContext translationTable.CvParams
////                                                                         ) 
////                         ) |> List

////    let convertToEntityDatabaseTranslation  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.DatabaseTranslation option) =
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value
////                |> (fun databaseTranslationItem -> createDatabaseTranslation (if databaseTranslationItem.Frames.IsSome 
////                                                                                 then databaseTranslationItem.Frames.Value
////                                                                                 else null
////                                                                             ) 
////                                                                             (convertToEntityTranslationTables dbContext databaseTranslationItem.TranslationTables
////                                                                             )
////                   )
////           else createDatabaseTranslation null null

////    let convertToEntityParentToleranceCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createParentToleranceParam (*cvParamItem.Name*)
////                                                                         //cvParamItem.Accession 
////                                                                         (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                         (takeTermID dbContext cvParamItem.CvRef)
////                                                                         (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                         (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
                                                                                                                                                                                         
////                                             )
////                         ) |> List

////    let convertToEntityParentTolerance  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.ParentTolerance option) =
////        if mzIdentMLXML.IsSome 
////            then mzIdentMLXML.Value
////                 |> (fun parentToleranceItem -> createParentTolerance (convertToEntityParentToleranceCVParams dbContext parentToleranceItem.CvParams)
////                    ) 
////            else createParentTolerance null

////    let convertToEntityThresholdOfSpectumIdentificationprotocolCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =  
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createThresholdParam (*cvParamItem.Name*)
////                                                                   //cvParamItem.Accession 
////                                                                   (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                   (takeTermID dbContext cvParamItem.CvRef)
////                                                                   (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                   (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
                                                                                                                                                                                         
////                                             )
////                         ) |> List

////    let convertToEntityThreshold  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Threshold) = 
////        mzIdentMLXML
////            |> (fun thresholdItem -> (createThreshold (convertToEntityThresholdOfSpectumIdentificationprotocolCVParams dbContext thresholdItem.CvParams
////                                                      )
////                                                      (thresholdItem.UserParams
////                                                          |> convertToEntityUserParams dbContext
////                                                      )
////                                     )
////               )

////    let convertToEntitySpectrumIdentificationProtocols  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SpectrumIdentificationProtocol []) =  
////        mzIdentMLXML
////        |> Array.map (fun spectrumIdentificationProtocolItem -> createSpectrumIdentificationProtocol (spectrumIdentificationProtocolItem.Id
////                                                                                                     ) 
////                                                                                                     //(if spectrumIdentificationProtocolItem.Name.IsSome 
////                                                                                                     //    then spectrumIdentificationProtocolItem.Name.Value 
////                                                                                                     //    else null) 
////                                                                                                     (spectrumIdentificationProtocolItem.AnalysisSoftwareRef
////                                                                                                     )
////                                                                                                     (convertToEntitySearchType dbContext spectrumIdentificationProtocolItem.SearchType
////                                                                                                     )
////                                                                                                     (if spectrumIdentificationProtocolItem.AdditionalSearchParams.IsSome 
////                                                                                                         then convertToEntityAdditionalSearchParams dbContext spectrumIdentificationProtocolItem.AdditionalSearchParams
////                                                                                                         else createAdditionalSearchParams null null
////                                                                                                     )
////                                                                                                     (if spectrumIdentificationProtocolItem.ModificationParams.IsSome 
////                                                                                                         then convertToEntityModificationParams dbContext spectrumIdentificationProtocolItem.ModificationParams
////                                                                                                         else createModificationParams null
////                                                                                                     )  
////                                                                                                     (convertToEntityEnzymes dbContext spectrumIdentificationProtocolItem.Enzymes
////                                                                                                     ) 
////                                                                                                     (convertToEntityMassTables dbContext spectrumIdentificationProtocolItem.MassTables
////                                                                                                     )
////                                                                                                     (convertToEntityFragmentTolerance dbContext spectrumIdentificationProtocolItem.FragmentTolerance
////                                                                                                     )
////                                                                                                     (convertToEntityParentTolerance dbContext spectrumIdentificationProtocolItem.ParentTolerance
////                                                                                                     )
////                                                                                                     (convertToEntityDatabaseFilters dbContext spectrumIdentificationProtocolItem.DatabaseFilters
////                                                                                                     )
////                                                                                                     (convertToEntityDatabaseTranslation dbContext spectrumIdentificationProtocolItem.DatabaseTranslation
////                                                                                                     )
////                                                                                                     (convertToEntityThreshold dbContext spectrumIdentificationProtocolItem.Threshold
////                                                                                                     )
////                     ) |> List

////    let convertToEntityProteinDetectionProtocol  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.ProteinDetectionProtocol option) = 
////        (if mzIdentMLXML.IsSome 
////            then mzIdentMLXML.Value
////                |> (fun proteinDetectionProtocolItem -> createProteinDetectionProtocol (proteinDetectionProtocolItem.Id) 
////                                                                                       (proteinDetectionProtocolItem.AnalysisSoftwareRef)
////                                                                                       (convertToEntityAnalysisParams dbContext proteinDetectionProtocolItem.AnalysisParams)
////                                                                                       (convertToEntityThresholdOfProteinDetection dbContext proteinDetectionProtocolItem.Threshold)
////                                                                                       (*(if proteinDetectionProtocolItem.Name.IsSome then proteinDetectionProtocolItem.Name.Value else null)*)                 
////                   )
////            else createProteinDetectionProtocol null null (createAnalysisParams null null) (createThreshold null null))  
   
////    let convertToEntityAnalysisProtocolCollection  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.AnalysisProtocolCollection) =
////         mzIdentMLXML
////            |> (fun analysisProtocolCollectionItem -> createAnalysisProtocolCollection (convertToEntitySpectrumIdentificationProtocols dbContext mzIdentMLXML.SpectrumIdentificationProtocols)
////                                                                                       (if analysisProtocolCollectionItem.ProteinDetectionProtocol.IsSome 
////                                                                                          then convertToEntityProteinDetectionProtocol dbContext mzIdentMLXML.ProteinDetectionProtocol
////                                                                                          else createProteinDetectionProtocol null null (createAnalysisParams null null) (createThreshold null null)
////                                                                                       )
////               )

////    let convertToEntityRoleCVParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam) =
////        mzIdentMLXML
////            |> (fun cvParamItem -> createRoleParam (*cvParamItem.Name*)
////                                                   //cvParamItem.Accession 
////                                                   (if cvParamItem.Value.IsSome 
////                                                       then cvParamItem.Value.Value 
////                                                       else null
////                                                   )
////                                                   (takeTermID dbContext cvParamItem.CvRef)
////                                                   (if cvParamItem.UnitCvRef.IsSome 
////                                                       then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                       else null
////                                                   )
////                                                   (if cvParamItem.UnitName.IsSome 
////                                                       then cvParamItem.UnitName.Value 
////                                                       else null
////                                                   )
////               )

////    let convertToEntityRole  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Role) =
////        mzIdentMLXML
////            |> (fun rolteItem -> createRole (convertToEntityRoleCVParam dbContext rolteItem.CvParam)
////               )

////    let convertToEntityContactRoleOption  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.ContactRole option) =
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value
////                |> (fun contactRoleItem -> (createContactRole contactRoleItem.ContactRef (convertToEntityRole dbContext contactRoleItem.Role))
////                   )
////           else createContactRole null (createRole (createRoleParam null null null null))

////    let convertToEntitySoftwareNameCVParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam option) =
////         if mzIdentMLXML.IsSome 
////            then mzIdentMLXML.Value
////                        |> (fun cvParamItem -> (createSoftwareNameParam (*cvParamItem.Name*)
////                                                                        //cvParamItem.Accession 
////                                                                        (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                        (takeTermID dbContext cvParamItem.CvRef)
////                                                                        (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                        (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
////                                                )
////                            )
////            else createSoftwareNameParam null null null null

////    let convertToEntitySoftwareName  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SoftwareName) =
////        mzIdentMLXML
////            |> (fun softwareNameItem -> createSoftwareName (convertToEntitySoftwareNameCVParam dbContext softwareNameItem.CvParam
////                                                           ) 
////                                                           (convertToEntityUserParam dbContext softwareNameItem.UserParam
////                                                           )               
////               )

////    let convertToEntityAnalysisSoftWares  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.AnalysisSoftware []) =
////        mzIdentMLXML
////            |> Array.map (fun analysisSoftareListItem -> createAnalysisSoftware analysisSoftareListItem.Id 
////                                                                                //(if analysisSoftareListItem.Name.IsSome 
////                                                                                //    then analysisSoftareListItem.Name.Value 
////                                                                                //    else null), 
////                                                                                (if analysisSoftareListItem.Uri.IsSome 
////                                                                                    then analysisSoftareListItem.Uri.Value 
////                                                                                    else null)
////                                                                                (convertToEntityContactRoleOption dbContext analysisSoftareListItem.ContactRole
////                                                                                )
////                                                                                (convertToEntitySoftwareName dbContext analysisSoftareListItem.SoftwareName
////                                                                                )
////                                                                                (if analysisSoftareListItem.Customizations.IsSome 
////                                                                                    then analysisSoftareListItem.Customizations.Value 
////                                                                                    else null
////                                                                                ) 
////                                                                                (if analysisSoftareListItem.Version.IsSome 
////                                                                                    then analysisSoftareListItem.Version.Value 
////                                                                                    else null
////                                                                                )                                 
////                         ) |> List

////    let convertToEntityAnalysisSoftwareList  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =
////        if mzIdentMLXML.AnalysisSoftwareList.IsSome 
////           then createAnalysisSoftwareList (convertToEntityAnalysisSoftWares dbContext mzIdentMLXML.AnalysisSoftwareList.Value.AnalysisSoftwares)
////           else createAnalysisSoftwareList null
    
////    let convertToEntityParent (mzIdentMLXML : SchemePeptideShaker.Parent option) =
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value
////                |> (fun parentItem -> createParent parentItem.OrganizationRef)
////            else createParent null

////    let convertToEntityOrganizationCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) = 
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createOrganizationParam (*cvParamItem.Name*)
////                                                                      //cvParamItem.Accession 
////                                                                      (if cvParamItem.Value.IsSome 
////                                                                          then cvParamItem.Value.Value 
////                                                                          else null)
////                                                                      (takeTermID dbContext cvParamItem.CvRef)
////                                                                      (if cvParamItem.UnitCvRef.IsSome 
////                                                                          then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                          else null)
////                                                                      (if cvParamItem.UnitName.IsSome
////                                                                          then cvParamItem.UnitName.Value 
////                                                                          else null)
////                                             )
////                         ) |> List

////    let convertToEntityOrganizations  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Organization []) =
////        mzIdentMLXML
////            |> Array.map (fun orgItem -> createOrganization orgItem.Id
////                                                            (convertToEntityParent orgItem.Parent
////                                                            )
////                                                            //(if orgItem.Name.IsSome 
////                                                            //    then orgItem.Name.Value 
////                                                            //    else null)
////                                                            (convertToEntityOrganizationCVParams dbContext orgItem.CvParams
////                                                            )
////                                                            (convertToEntityUserParams dbContext orgItem.UserParams
////                                                            )
////                         ) |> List

////    let convertToEntityPersonCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =  
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createPersonParam (*cvParamItem.Name*)
////                                                               //cvParamItem.Accession 
////                                                               (if cvParamItem.Value.IsSome 
////                                                                   then cvParamItem.Value.Value 
////                                                                   else null)
////                                                               (takeTermID dbContext cvParamItem.CvRef)
////                                                               (if cvParamItem.UnitCvRef.IsSome 
////                                                                   then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                   else null)
////                                                               (if cvParamItem.UnitName.IsSome 
////                                                                   then cvParamItem.UnitName.Value 
////                                                                   else null)   
////                         ) |> List

////    let convertToEntityAffiliations (mzIdentMLXML : SchemePeptideShaker.Affiliation []) = 
////        mzIdentMLXML
////            |> Array.map (fun affiliationItem -> (createAffiliation affiliationItem.OrganizationRef)
////                         ) |> List

////    let convertToEntityPersons  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Person []) =    
////        mzIdentMLXML
////            |> Array.map (fun personItem -> createPerson personItem.Id
////                                                            //(if personItem.Name.IsSome then personItem.Name.Value else null), 
////                                                            (if personItem.FirstName.IsSome 
////                                                                then personItem.FirstName.Value 
////                                                                else null)
////                                                            (if personItem.MidInitials.IsSome 
////                                                                then personItem.MidInitials.Value 
////                                                                else null)
////                                                            (if personItem.LastName.IsSome 
////                                                                then personItem.LastName.Value 
////                                                                else null)  
////                                                            (convertToEntityAffiliations personItem.Affiliations
////                                                            )
////                                                            (convertToEntityPersonCVParams dbContext personItem.CvParams
////                                                            )
////                                                            (convertToEntityUserParams dbContext personItem.UserParams
////                                                            )
////                            ) |> List

////    let convertToEntityAuditCollection  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =
////        if mzIdentMLXML.AuditCollection.IsSome
////           then mzIdentMLXML.AuditCollection.Value
////                |> (fun auditCollectionItem -> createAuditCollection (convertToEntityOrganizations dbContext auditCollectionItem.Organizations
////                                                                     )
////                                                                     (convertToEntityPersons dbContext  auditCollectionItem.Persons
////                                                                     )
////                   )
////           else createAuditCollection null null

////    let convertToEntitySpectrumIdentificationItemRefs (mzIdentMLXML : SchemePeptideShaker.SpectrumIdentificationItemRef []) = 
////        mzIdentMLXML
////            |> Array.map (fun spectrumIdentificationItemRefItem -> createSpectrumIdentificationItemRef spectrumIdentificationItemRefItem.SpectrumIdentificationItemRef
////                         ) |> List

////    let convertToEntityPeptideHypothesis (mzIdentMLXML : SchemePeptideShaker.PeptideHypothesis []) =   
////        mzIdentMLXML
////            |> Array.map (fun peptideHypothesisItem -> createPeptideHypothesis  peptideHypothesisItem.PeptideEvidenceRef 
////                                                                                (convertToEntitySpectrumIdentificationItemRefs peptideHypothesisItem.SpectrumIdentificationItemRefs
////                                                                                )                                                        
////                         ) |> List

////    let convertToEntityProteinDetectionHypthesisCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =   
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createProteinDetectionHypothesisParam (*cvParamItem.Name*)
////                                                                                    //cvParamItem.Accession 
////                                                                                    (if cvParamItem.Value.IsSome 
////                                                                                        then cvParamItem.Value.Value 
////                                                                                        else null)
////                                                                                    (takeTermID dbContext cvParamItem.CvRef)
////                                                                                    (if cvParamItem.UnitCvRef.IsSome 
////                                                                                        then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                                        else null)
////                                                                                    (if cvParamItem.UnitName.IsSome 
////                                                                                        then cvParamItem.UnitName.Value 
////                                                                                        else null)
////                                             )
////                         ) |> List

////    let convertToEntityProteinDetectionHypthesis  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.ProteinDetectionHypothesis []) =
////        mzIdentMLXML
////            |> Array.map (fun proteinDetectionHypothesisItem -> createProteinDetectionHypothesis    proteinDetectionHypothesisItem.Id 
////                                                                                                    //(if proteinDetectionHypothesisItem.Name.IsSome
////                                                                                                    //    then proteinDetectionHypothesisItem.Name.Value 
////                                                                                                    //    else null), 
////                                                                                                    (proteinDetectionHypothesisItem.DBSequenceRef)
////                                                                                                    (proteinDetectionHypothesisItem.PassThreshold)
////                                                                                                    (convertToEntityPeptideHypothesis proteinDetectionHypothesisItem.PeptideHypotheses
////                                                                                                    )
////                                                                                                    (convertToEntityProteinDetectionHypthesisCVParams dbContext proteinDetectionHypothesisItem.CvParams
////                                                                                                    ) 
////                                                                                                    (convertToEntityUserParams dbContext proteinDetectionHypothesisItem.UserParams
////                                                                                                    ) 
                                                                                                                                                                                                             
////                         ) |> List

////    let convertToEntityProteinAmbiguityGroupsCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =  
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> (createProteinAmbiguityGroupParam (*cvParamItem.Name*)
////                                                                               //cvParamItem.Accession 
////                                                                               (if cvParamItem.Value.IsSome 
////                                                                                   then cvParamItem.Value.Value 
////                                                                                   else null)
////                                                                               (takeTermID dbContext cvParamItem.CvRef)
////                                                                               (if cvParamItem.UnitCvRef.IsSome 
////                                                                                   then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                                   else null)
////                                                                               (if cvParamItem.UnitName.IsSome 
////                                                                                   then cvParamItem.UnitName.Value 
////                                                                                   else null)
////                                             )
////                         ) |> List

////    let convertToEntityProteinAmbiguityGroups  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.ProteinAmbiguityGroup []) =
////        mzIdentMLXML
////            |> Array.map (fun proteinAmbiguityGroupItem -> createProteinAmbiguityGroup proteinAmbiguityGroupItem.Id
////                                                                                       //(if proteinAmbiguityGroupItem.Name.IsSome 
////                                                                                       //    then proteinAmbiguityGroupItem.Name.Value 
////                                                                                       //    else null),
////                                                                                       (convertToEntityProteinDetectionHypthesis dbContext proteinAmbiguityGroupItem.ProteinDetectionHypotheses
////                                                                                       )
////                                                                                       (convertToEntityProteinAmbiguityGroupsCVParams dbContext proteinAmbiguityGroupItem.CvParams
////                                                                                       )
////                                                                                       (convertToEntityUserParams dbContext proteinAmbiguityGroupItem.UserParams
////                                                                                       )
                                                                                                                                                   
////                         ) |> List

////    let convertToEntityProteinDetectionListCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =   
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createProteinDetectionListParam (*cvParamItem.Name*)
////                                                                             //cvParamItem.Accession 
////                                                                             (if cvParamItem.Value.IsSome 
////                                                                                then cvParamItem.Value.Value 
////                                                                                else null)
////                                                                             (takeTermID dbContext cvParamItem.CvRef)
////                                                                             (if cvParamItem.UnitCvRef.IsSome 
////                                                                                then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                                else null)
////                                                                             (if cvParamItem.UnitName.IsSome 
////                                                                                 then cvParamItem.UnitName.Value 
////                                                                                 else null)   
////                         ) |> List

////    let convertToEntityProteinDetectionList  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.ProteinDetectionList option) = 
////         if mzIdentMLXML.IsSome 
////            then mzIdentMLXML.Value
////                |> (fun proteinDetectionItem -> createProteinDetectionList  proteinDetectionItem.Id
////                                                                            //(if proteinDetectionItem.Name.IsSome 
////                                                                            //    then proteinDetectionItem.Name.Value 
////                                                                            //    else null)
////                                                                            (convertToEntityProteinAmbiguityGroups dbContext proteinDetectionItem.ProteinAmbiguityGroups)
////                                                                            (convertToEntityProteinDetectionListCVParams dbContext proteinDetectionItem.CvParams)
////                                                                            (convertToEntityUserParams dbContext proteinDetectionItem.UserParams)
                                                                            
////                   )
////            else createProteinDetectionList null null null null               

////    let convertToEntityMeasureCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createMeasureParam (*cvParamItem.Name*)
////                                                                //cvParamItem.Accession 
////                                                                (if cvParamItem.Value.IsSome 
////                                                                    then cvParamItem.Value.Value 
////                                                                    else null)
////                                                                (takeTermID dbContext cvParamItem.CvRef)
////                                                                (if cvParamItem.UnitCvRef.IsSome 
////                                                                    then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                    else null)
////                                                                (if cvParamItem.UnitName.IsSome 
////                                                                    then cvParamItem.UnitName.Value 
////                                                                    else null)
////                         ) |> List

////    let convertToEntityMesasure  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Measure []) =
////        mzIdentMLXML
////            |> Array.map (fun measureItem -> createMeasure measureItem.Id
////                                                           //(if measureItem.Name.IsSome 
////                                                           //    then measureItem.Name.Value 
////                                                           //    else null)
////                                                           (convertToEntityMeasureCVParams dbContext measureItem.CvParams
////                                                           )
////                         ) |> List

////    let convertToEntityFragmentationTable  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.FragmentationTable option) =
////         if mzIdentMLXML.IsSome 
////            then mzIdentMLXML.Value
////                 |> (fun fragmentationTableItem -> createFragmentationTable (convertToEntityMesasure dbContext fragmentationTableItem.Measures
////                                                                            )
////                    )
////            else createFragmentationTable null


////    let convertToEntityFragmentArray (mzIdentMLXML : SchemePeptideShaker.FragmentArray []) =    
////        mzIdentMLXML
////            |> Array.map (fun fragmentItem -> createFragmentArray fragmentItem.Values
////                                                                  fragmentItem.MeasureRef
////                         ) |> List 

////    let convertToEntityIonTypeCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) = 
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createIonTypeParam (*cvParamItem.Name*)
////                                                                //cvParamItem.Accession 
////                                                                (if cvParamItem.Value.IsSome 
////                                                                    then cvParamItem.Value.Value 
////                                                                    else null)
////                                                                (takeTermID dbContext cvParamItem.CvRef)
////                                                                (if cvParamItem.UnitCvRef.IsSome 
////                                                                    then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                    else null)
////                                                                (if cvParamItem.UnitName.IsSome 
////                                                                    then cvParamItem.UnitName.Value 
////                                                                    else null)
////                         ) |> List 

////    let convertToEntityIonTypes  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.IonType []) =
////        mzIdentMLXML
////            |> Array.map (fun ionTypeItem -> createIonType (if ionTypeItem.Index.IsSome 
////                                                               then ionTypeItem.Index.Value 
////                                                               else null)
////                                                           ionTypeItem.Charge
////                                                           (convertToEntityFragmentArray ionTypeItem.FragmentArray
////                                                           )
////                                                           (convertToEntityIonTypeCVParams dbContext ionTypeItem.CvParams
////                                                           )
////                                                           (convertToEntityUserParams dbContext ionTypeItem.UserParams
////                                                           )
                                                                                                                                                                                                                                               
////                         ) |> List

////    let convertToEntityFragmentation  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Fragmentation option) =
////        if mzIdentMLXML.IsSome 
////           then mzIdentMLXML.Value
////                |> (fun fragmentationItem -> createFragmentation (convertToEntityIonTypes dbContext fragmentationItem.IonTypes
////                                                                 )
////                   )
////            else createFragmentation null

////    let convertToEntityPeptideEvidenceRef (mzIdentMLXML : SchemePeptideShaker.PeptideEvidenceRef []) =  
////        mzIdentMLXML
////            |> Array.map (fun peptideEvidenceItem -> createPeptideEvidenceRef peptideEvidenceItem.PeptideEvidenceRef
////                         ) |> List

////    let convertToEntitySpectrumIdentificationItemCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =  
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createSpectrumIdentificationItemParam  (*cvParamItem.Name*)
////                                                                                    //cvParamItem.Accession 
////                                                                                    (if cvParamItem.Value.IsSome 
////                                                                                        then cvParamItem.Value.Value 
////                                                                                        else null)
////                                                                                    (takeTermID dbContext cvParamItem.CvRef)
////                                                                                    (if cvParamItem.UnitCvRef.IsSome 
////                                                                                        then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                                        else null)
////                                                                                    (if cvParamItem.UnitName.IsSome 
////                                                                                        then cvParamItem.UnitName.Value 
////                                                                                        else null)
                                                                                                                                                                                                 
////                         ) |> List 

////    let convertToEntitySpectrumIdentificationItems  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SpectrumIdentificationItem []) =  
////        mzIdentMLXML
////            |> Array.map (fun spectrumIdentificationItem -> createSpectrumIdentificationItem spectrumIdentificationItem.Id
////                                                                                             //(if spectrumIdentificationItem.Name.IsSome 
////                                                                                             //    then spectrumIdentificationItem.Name.Value 
////                                                                                             //    else null)
////                                                                                             spectrumIdentificationItem.PeptideRef
////                                                                                             spectrumIdentificationItem.ChargeState
////                                                                                             (if spectrumIdentificationItem.SampleRef.IsSome 
////                                                                                                 then spectrumIdentificationItem.SampleRef.Value 
////                                                                                                 else null
////                                                                                             )
////                                                                                             spectrumIdentificationItem.PassThreshold
////                                                                                             (convertToEntityFragmentation dbContext spectrumIdentificationItem.Fragmentation
////                                                                                             )
////                                                                                             spectrumIdentificationItem.Rank
////                                                                                             (if spectrumIdentificationItem.MassTableRef.IsSome 
////                                                                                                 then spectrumIdentificationItem.MassTableRef.Value 
////                                                                                                 else null
////                                                                                             )
////                                                                                             (if spectrumIdentificationItem.CalculatedPi.IsSome 
////                                                                                                 then spectrumIdentificationItem.CalculatedPi.Value 
////                                                                                                 else null
////                                                                                             )
////                                                                                             (if spectrumIdentificationItem.CalculatedMassToCharge.IsSome 
////                                                                                                 then spectrumIdentificationItem.CalculatedMassToCharge.Value 
////                                                                                                 else -1.
////                                                                                             )
////                                                                                             spectrumIdentificationItem.ExperimentalMassToCharge
////                                                                                             (convertToEntityPeptideEvidenceRef spectrumIdentificationItem.PeptideEvidenceRefs
////                                                                                             )
////                                                                                             (convertToEntitySpectrumIdentificationItemCVParams dbContext spectrumIdentificationItem.CvParams
////                                                                                             )
////                                                                                             (convertToEntityUserParams dbContext spectrumIdentificationItem.UserParams
////                                                                                             )
                                                                                                                                                                    
////                         ) |> List


////    let convertToEntitySpectrumIdentificationResultsCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createSpectrumIdentificationResultParam (*cvParamItem.Name*)
////                                                                                     //cvParamItem.Accession 
////                                                                                     (if cvParamItem.Value.IsSome 
////                                                                                         then cvParamItem.Value.Value 
////                                                                                         else null)
////                                                                                     (takeTermID dbContext cvParamItem.CvRef)
////                                                                                     (if cvParamItem.UnitCvRef.IsSome  
////                                                                                         then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                                         else null)
////                                                                                     (if cvParamItem.UnitName.IsSome 
////                                                                                         then cvParamItem.UnitName.Value 
////                                                                                         else null)
////                         ) |> List

////    let convertToEntitySpectrumIdentificationResults  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SpectrumIdentificationResult []) =
////        mzIdentMLXML
////            |> Array.map (fun spectrumIdentificationResultItem -> createSpectrumIdentificationResult spectrumIdentificationResultItem.Id
////                                                                                                     spectrumIdentificationResultItem.SpectrumId
////                                                                                                     //(if spectrumIdentificationResultItem.Name.IsSome 
////                                                                                                     //    then spectrumIdentificationResultItem.Name.Value 
////                                                                                                     //    else null), 
////                                                                                                     spectrumIdentificationResultItem.SpectraDataRef
////                                                                                                     (convertToEntitySpectrumIdentificationItems dbContext spectrumIdentificationResultItem.SpectrumIdentificationItems
////                                                                                                     )
////                                                                                                     (convertToEntitySpectrumIdentificationResultsCVParams dbContext spectrumIdentificationResultItem.CvParams
////                                                                                                     )
////                                                                                                     (convertToEntityUserParams dbContext spectrumIdentificationResultItem.UserParams
////                                                                                                     )
////                         ) |> List
 

////    let convertToEntitySpectrumIdentificationListCVParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createSpectrumIdentificationListParam (*cvParamItem.Name*)
////                                                                                   //cvParamItem.Accession 
////                                                                                   (if cvParamItem.Value.IsSome then cvParamItem.Value.Value else null)
////                                                                                   (takeTermID dbContext cvParamItem.CvRef)
////                                                                                   (if cvParamItem.UnitCvRef.IsSome then (takeTermID dbContext cvParamItem.UnitCvRef.Value) else null)
////                                                                                   (if cvParamItem.UnitName.IsSome then cvParamItem.UnitName.Value else null)
                                          
////                         ) |> List

////    let convertToEntitySpectrumIdentificationList  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SpectrumIdentificationList []) =
////        mzIdentMLXML
////            |> Array.map (fun spectrumIdentificationItem -> createSpectrumIdentificationList spectrumIdentificationItem.Id
////                                                                                             //(if spectrumIdentificationItem.Name.IsSome 
////                                                                                             //    then spectrumIdentificationItem.Name.Value 
////                                                                                             //    else null), 
////                                                                                             (if spectrumIdentificationItem.NumSequencesSearched.IsSome 
////                                                                                                 then int spectrumIdentificationItem.NumSequencesSearched.Value 
////                                                                                                 else int -1
////                                                                                             )
////                                                                                             (convertToEntityFragmentationTable dbContext spectrumIdentificationItem.FragmentationTable
////                                                                                             )
////                                                                                             (convertToEntitySpectrumIdentificationResults dbContext spectrumIdentificationItem.SpectrumIdentificationResults
////                                                                                             )
////                                                                                             (convertToEntitySpectrumIdentificationListCVParam dbContext spectrumIdentificationItem.CvParams
////                                                                                             ) 
////                                                                                             (convertToEntityUserParams dbContext spectrumIdentificationItem.UserParams
////                                                                                             )
////                         ) |> List
 
////    let convertToEntityAnalysisData  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.AnalysisData) =    
////        mzIdentMLXML
////        |> (fun analysisDataItem -> createAnalysisData (convertToEntitySpectrumIdentificationList dbContext analysisDataItem.SpectrumIdentificationList)
////                                                       (if analysisDataItem.ProteinDetectionList.IsSome 
////                                                           then (convertToEntityProteinDetectionList dbContext analysisDataItem.ProteinDetectionList)
////                                                           else createProteinDetectionList null null null null) 
                                                   
////           ) 

////    let convertToEntitySearchDatabasesCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createSearchDatabaseParam (*cvParamItem.Name*)
////                                                                       //cvParamItem.Accession 
////                                                                       (if cvParamItem.Value.IsSome 
////                                                                           then cvParamItem.Value.Value 
////                                                                           else null)
////                                                                       (takeTermID dbContext cvParamItem.CvRef)
////                                                                       (if cvParamItem.UnitCvRef.IsSome 
////                                                                           then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                           else null)
////                                                                       (if cvParamItem.UnitName.IsSome 
////                                                                           then cvParamItem.UnitName.Value 
////                                                                           else null)
////                                                                        ) |> List

////    let convertToEntityDatabaseNameCVParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam option) =  
////        if mzIdentMLXML.IsSome 
////            then mzIdentMLXML.Value
////                    |> (fun cvParamItem -> (createDatabaseNameParam (*cvParamItem.Name*)
////                                                                    //cvParamItem.Accession 
////                                                                    (if cvParamItem.Value.IsSome 
////                                                                        then cvParamItem.Value.Value 
////                                                                        else null)
////                                                                    (takeTermID dbContext cvParamItem.CvRef)
////                                                                    (if cvParamItem.UnitCvRef.IsSome 
////                                                                        then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                        else null)
////                                                                    (if cvParamItem.UnitName.IsSome 
////                                                                        then cvParamItem.UnitName.Value 
////                                                                        else null)
////                                            )
////                        )
////            else createDatabaseNameParam null null null null

////    let convertToEntityDatabaseName  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.DatabaseName) =  
////        mzIdentMLXML
////        |> (fun databaseNameItem -> createDatabaseName  (convertToEntityDatabaseNameCVParam dbContext databaseNameItem.CvParam
////                                                        )
////                                                        (convertToEntityUserParam dbContext databaseNameItem.UserParam
////                                                        )
////           )

////    let convertToEntityFileFormatSearchDataBase (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) = 
////        mzIdentMLXML.DataCollection.Inputs
////            |> (fun inputItem -> inputItem.SearchDatabases
////                                |> Array.map (fun searchDatabaseItem -> searchDatabaseItem.FileFormat
////                                                                        |> (fun fileFormatItem -> fileFormatItem.CvParam)))

////    let convertToEntitySourceFileCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =  
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createSourceFileParam (*cvParamItem.Name*)
////                                                                   //cvParamItem.Accession 
////                                                                   (if cvParamItem.Value.IsSome 
////                                                                       then cvParamItem.Value.Value 
////                                                                       else null
////                                                                   )
////                                                                   (takeTermID dbContext cvParamItem.CvRef)
////                                                                   (if cvParamItem.UnitCvRef.IsSome 
////                                                                       then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                       else null
////                                                                   )
////                                                                   (if cvParamItem.UnitName.IsSome 
////                                                                       then cvParamItem.UnitName.Value 
////                                                                       else null
////                                                                   )
////                         ) |> List

////    let convertToEntityFileFormatCVParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam) =
////        mzIdentMLXML
////            |> (fun cvParamItem -> createFileFormatParam (*cvParamItem.Name*)
////                                                         //cvParamItem.Accession 
////                                                         (if cvParamItem.Value.IsSome 
////                                                             then cvParamItem.Value.Value 
////                                                             else null
////                                                         )
////                                                         (takeTermID dbContext cvParamItem.CvRef)
////                                                         (if cvParamItem.UnitCvRef.IsSome 
////                                                             then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                             else null
////                                                         )
////                                                         (if cvParamItem.UnitName.IsSome 
////                                                             then cvParamItem.UnitName.Value 
////                                                             else null
////                                                         )
////               )

////    let convertToEntityFileFormat  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.FileFormat) =
////        mzIdentMLXML
////            |> (fun fileFormatItem -> createFileFormat (convertToEntityFileFormatCVParam dbContext fileFormatItem.CvParam)
////               )

////    let convertToEntitySourceFiles  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SourceFile []) = 
////        mzIdentMLXML
////            |> Array.map (fun sourceFileItem -> createSourceFile (sourceFileItem.Id
////                                                                 )
////                                                                 //(if sourceFileItem.Name.IsSome 
////                                                                 //    then sourceFileItem.Name.Value 
////                                                                 //    else null
////                                                                 //)
////                                                                 (sourceFileItem.Location
////                                                                 )
////                                                                 (convertToEntityFileFormat dbContext sourceFileItem.FileFormat
////                                                                 )
////                                                                 (if sourceFileItem.ExternalFormatDocumentation.IsSome 
////                                                                     then sourceFileItem.ExternalFormatDocumentation.Value 
////                                                                     else null
////                                                                 )    
////                                                                 (convertToEntitySourceFileCVParams dbContext sourceFileItem.CvParams
////                                                                 ) 
////                                                                 (convertToEntityUserParams dbContext sourceFileItem.UserParams
////                                                                 )
////                         ) |> List

////    let convertToEntitySpectrumIDFormatCvParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam) =
////        mzIdentMLXML
////            |> (fun cvParamItem -> createSpectrumIDFormatParam (*cvParamItem.Name*)
////                                                               //cvParamItem.Accession 
////                                                               (if cvParamItem.Value.IsSome 
////                                                                   then cvParamItem.Value.Value 
////                                                                   else null
////                                                               )
////                                                               (takeTermID dbContext cvParamItem.CvRef)
////                                                               (if cvParamItem.UnitCvRef.IsSome 
////                                                                   then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                   else null
////                                                               )
////                                                               (if cvParamItem.UnitName.IsSome 
////                                                                   then cvParamItem.UnitName.Value 
////                                                                   else null
////                                                               )
////               )

////    let convertToEntitySpectrumIDFormat  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SpectrumIdFormat) =
////        mzIdentMLXML
////            |> (fun spectrumIDFormatItem -> createSpectrumIDFormat (convertToEntitySpectrumIDFormatCvParam dbContext spectrumIDFormatItem.CvParam)
////               )

////    let convertToEntitySpectraDatas  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SpectraData []) =
////        mzIdentMLXML
////            |> Array.map (fun spectraDataItem -> createSpectraData (spectraDataItem.Id
////                                                                   )
////                                                                   //(if spectraDataItem.Name.IsSome 
////                                                                   //    then spectraDataItem.Name.Value 
////                                                                   //    else null)
////                                                                   (spectraDataItem.Location
////                                                                   )
////                                                                   (convertToEntityFileFormat dbContext spectraDataItem.FileFormat
////                                                                   )
////                                                                   (if spectraDataItem.ExternalFormatDocumentation.IsSome 
////                                                                       then spectraDataItem.ExternalFormatDocumentation.Value 
////                                                                       else null
////                                                                   ) 
////                                                                   (convertToEntitySpectrumIDFormat dbContext spectraDataItem.SpectrumIdFormat
////                                                                   )
////                         ) |> List

////    let convertToEntitySearchDatabases  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SearchDatabase []) =   
////        mzIdentMLXML
////            |> Array.map (fun searchDatabaseItem -> createSearchDatabase (searchDatabaseItem.Id
////                                                                         )
////                                                                         (searchDatabaseItem.Location
////                                                                         )
////                                                                         (if searchDatabaseItem.NumResidues.IsSome 
////                                                                             then int searchDatabaseItem.NumResidues.Value 
////                                                                             else -1
////                                                                         )
////                                                                         (if searchDatabaseItem.NumDatabaseSequences.IsSome 
////                                                                             then int searchDatabaseItem.NumDatabaseSequences.Value 
////                                                                             else -1
////                                                                         )
////                                                                         (if searchDatabaseItem.ReleaseDate.IsSome 
////                                                                             then searchDatabaseItem.ReleaseDate.Value 
////                                                                             else DateTime.UtcNow
////                                                                         )
////                                                                         (if searchDatabaseItem.Version.IsSome 
////                                                                             then searchDatabaseItem.Version.Value 
////                                                                             else null
////                                                                         )
////                                                                         //(if searchDatabaseItem.Name.IsSome 
////                                                                         //    then searchDatabaseItem.Name.Value 
////                                                                         //    else null), 
////                                                                         (if searchDatabaseItem.ExternalFormatDocumentation.IsSome 
////                                                                             then searchDatabaseItem.ExternalFormatDocumentation.Value 
////                                                                             else null
////                                                                         )
////                                                                         (convertToEntityFileFormat dbContext searchDatabaseItem.FileFormat
////                                                                         )
////                                                                         (convertToEntityDatabaseName dbContext searchDatabaseItem.DatabaseName
////                                                                         )
////                                                                         (convertToEntitySearchDatabasesCVParams dbContext searchDatabaseItem.CvParams
////                                                                         ) 
////                         ) |> List

////    let convertToEntityInputs  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Inputs) =
////        mzIdentMLXML
////            |> (fun inputItem -> createInputs (convertToEntitySearchDatabases dbContext inputItem.SearchDatabases
////                                              )
////                                              (convertToEntitySourceFiles dbContext inputItem.SourceFiles
////                                              )
////                                              (convertToEntitySpectraDatas dbContext inputItem.SpectraDatas
////                                              )
////               )

////    let convertToEntityDataCollection  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.DataCollection) =
////        mzIdentMLXML
////            |> (fun dataCollectionItem -> createDataCollection (convertToEntityInputs dbContext dataCollectionItem.Inputs
////                                                               )
////                                                               (convertToEntityAnalysisData dbContext dataCollectionItem.AnalysisData
////                                                               )
                                                           
////               )

////    let convertToEntityProvider  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =
////        if mzIdentMLXML.Provider.IsSome 
////           then mzIdentMLXML.Provider.Value
////               |> (fun providerItem -> createProvider (providerItem.Id
////                                                      )
////                                                      //(if providerItem.Name.IsSome 
////                                                      //    then providerItem.Name.Value 
////                                                      //    else null),
////                                                      (convertToEntityContactRoleOption dbContext providerItem.ContactRole
////                                                      )
////                                                      (if providerItem.AnalysisSoftwareRef.IsSome 
////                                                          then providerItem.AnalysisSoftwareRef.Value 
////                                                          else null
////                                                      )
////                   )
////            else createProvider null (createContactRole null (createRole (createRoleParam null null null null))) null

////    let convertToEntityModificationCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) = 
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createModificationParam (*cvParamItem.Name*)
////                                                                     //cvParamItem.Accession 
////                                                                     (if cvParamItem.Value.IsSome 
////                                                                         then cvParamItem.Value.Value 
////                                                                         else null
////                                                                     )
////                                                                     (takeTermID dbContext cvParamItem.CvRef)
////                                                                     (if cvParamItem.UnitCvRef.IsSome 
////                                                                         then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                         else null
////                                                                     )                                                                (if cvParamItem.UnitName.IsSome 
////                                                                         then cvParamItem.UnitName.Value 
////                                                                         else null
////                                                                     )
////                         ) |> List

////    let convertToEntityModifications  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Modification []) = 
////        mzIdentMLXML  
////            |> Array.map (fun modificationItem -> createModification (if modificationItem.AvgMassDelta.IsSome 
////                                                                         then modificationItem.AvgMassDelta.Value 
////                                                                         else -1.
////                                                                     )
////                                                                     (if modificationItem.MonoisotopicMassDelta.IsSome 
////                                                                         then modificationItem.MonoisotopicMassDelta.Value 
////                                                                         else -1.
////                                                                     )
////                                                                     (if modificationItem.Residues.IsSome 
////                                                                         then modificationItem.Residues.Value 
////                                                                         else null
////                                                                     )
////                                                                     (if modificationItem.Location.IsSome 
////                                                                         then modificationItem.Location.Value 
////                                                                         else -1
////                                                                     )
////                                                                     (convertToEntityModificationCVParams dbContext modificationItem.CvParams
////                                                                     )
////                         ) |> List

////    let convertToEntitySubstitutionModification (mzIdentMLXML : SchemePeptideShaker.SubstitutionModification []) =   
////        mzIdentMLXML
////            |> Array.map (fun substitutionModificationItem -> createSubstitutionModification (if substitutionModificationItem.MonoisotopicMassDelta.IsSome 
////                                                                                                 then substitutionModificationItem.MonoisotopicMassDelta.Value 
////                                                                                                 else -1.
////                                                                                             ) 
////                                                                                             (if substitutionModificationItem.AvgMassDelta.IsSome 
////                                                                                                 then substitutionModificationItem.AvgMassDelta.Value 
////                                                                                                 else -1.
////                                                                                             )
////                                                                                             (if substitutionModificationItem.Location.IsSome 
////                                                                                                 then substitutionModificationItem.Location.Value 
////                                                                                                 else -1
////                                                                                             )
////                                                                                             (substitutionModificationItem.OriginalResidue
////                                                                                             )
////                                                                                             (substitutionModificationItem.ReplacementResidue
////                                                                                             )
////                         ) |> List

////    let convertToEntityPeptideCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =   
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createPeptideParam (*cvParamItem.Name*)
////                                                                //cvParamItem.Accession 
////                                                                (if cvParamItem.Value.IsSome 
////                                                                    then cvParamItem.Value.Value 
////                                                                    else null
////                                                                )
////                                                                (takeTermID dbContext cvParamItem.CvRef)
////                                                                (if cvParamItem.UnitCvRef.IsSome 
////                                                                    then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                    else null
////                                                                )
////                                                                (if cvParamItem.UnitName.IsSome 
////                                                                    then cvParamItem.UnitName.Value 
////                                                                    else null
////                                                                )
////                         ) |> List

////    let convertToEntityPeptides  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Peptide []) =    
////        mzIdentMLXML
////            |> Array.map (fun peptideItem -> createPeptide (peptideItem.Id
////                                                           )
////                                                           //(if peptideItem.Name.IsSome 
////                                                           //    then peptideItem.Name.Value 
////                                                           //    else null
////                                                           //)
////                                                           (peptideItem.PeptideSequence
////                                                           )
////                                                           (convertToEntityModifications dbContext peptideItem.Modifications
////                                                           )
////                                                           (convertToEntitySubstitutionModification peptideItem.SubstitutionModifications
////                                                           )
////                                                           (convertToEntityPeptideCVParams dbContext peptideItem.CvParams
////                                                           )
////                                                           (convertToEntityUserParams dbContext peptideItem.UserParams
////                                                           )
////                         ) |> List

////    let convertToEntityPeptideEvidenceCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createPeptideEvidenceParam (*cvParamItem.Name*)
////                                                                        //cvParamItem.Accession 
////                                                                        (if cvParamItem.Value.IsSome 
////                                                                            then cvParamItem.Value.Value 
////                                                                            else null
////                                                                        )
////                                                                        (takeTermID dbContext cvParamItem.CvRef)
////                                                                        (if cvParamItem.UnitCvRef.IsSome 
////                                                                            then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                            else null
////                                                                        )
////                                                                        (if cvParamItem.UnitName.IsSome 
////                                                                            then cvParamItem.UnitName.Value 
////                                                                            else null
////                                                                        )
////                         ) |> List

////    let convertToEntityPeptideEvidence  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.PeptideEvidence []) = 
////        mzIdentMLXML
////            |> Array.map (fun peptideEvidenceItem -> createPeptideEvidence  (peptideEvidenceItem.Id
////                                                                            )
////                                                                            //(if peptideEvidenceItem.Name.IsSome 
////                                                                            //    then peptideEvidenceItem.Name.Value 
////                                                                            //    else null
////                                                                            //),  
////                                                                            (peptideEvidenceItem.PeptideRef
////                                                                            )
////                                                                            (peptideEvidenceItem.DBSequenceRef
////                                                                            )
////                                                                            (if peptideEvidenceItem.IsDecoy.IsSome 
////                                                                                then peptideEvidenceItem.IsDecoy.Value.ToString() 
////                                                                                else null
////                                                                            )
////                                                                            (if peptideEvidenceItem.Frame.IsSome 
////                                                                                then peptideEvidenceItem.Frame.Value 
////                                                                                else -1
////                                                                            )
////                                                                            (if peptideEvidenceItem.TranslationTableRef.IsSome 
////                                                                                then peptideEvidenceItem.TranslationTableRef.Value 
////                                                                                else null
////                                                                            )
////                                                                            (if peptideEvidenceItem.Start.IsSome 
////                                                                                then peptideEvidenceItem.Start.Value 
////                                                                                else -1
////                                                                            )
////                                                                            (if peptideEvidenceItem.End.IsSome 
////                                                                                then peptideEvidenceItem.End.Value 
////                                                                                else -1
////                                                                            )
////                                                                            (if peptideEvidenceItem.Pre.IsSome 
////                                                                                then peptideEvidenceItem.Pre.Value 
////                                                                                else null
////                                                                            )
////                                                                            (if peptideEvidenceItem.Post.IsSome 
////                                                                                then peptideEvidenceItem.Post.Value 
////                                                                                else null
////                                                                            )
////                                                                            (convertToEntityPeptideEvidenceCVParams dbContext peptideEvidenceItem.CvParams
////                                                                            )
////                                                                            (convertToEntityUserParams dbContext peptideEvidenceItem.UserParams
////                                                                            )
////                         ) |> List

////    let convertToEntityDBSequenceCVParams  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createDBSequenceParam (*cvParamItem.Name*)
////                                                                   //cvParamItem.Accession 
////                                                                   (if cvParamItem.Value.IsSome 
////                                                                       then cvParamItem.Value.Value 
////                                                                       else null
////                                                                   )
////                                                                   (takeTermID dbContext cvParamItem.CvRef)
////                                                                   (if cvParamItem.UnitCvRef.IsSome 
////                                                                       then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                       else null
////                                                                   )
////                                                                   (if cvParamItem.UnitName.IsSome 
////                                                                       then cvParamItem.UnitName.Value 
////                                                                       else null
////                                                                   )
////                         ) |> List

////    let convertToEntityDBSequence  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.DbSequence []) =  
////        mzIdentMLXML
////            |> Array.map (fun dbSequenceItem -> createDBSequence (dbSequenceItem.Id
////                                                                 )
////                                                                 //(if dbSequenceItem.Name.IsSome 
////                                                                 //    then dbSequenceItem.Name.Value 
////                                                                 //    else null
////                                                                 //)
////                                                                 (dbSequenceItem.Accession
////                                                                 )
////                                                                 (if dbSequenceItem.Length.IsSome 
////                                                                     then dbSequenceItem.Length.Value 
////                                                                     else -1
////                                                                 )
////                                                                 (if dbSequenceItem.Seq.IsSome 
////                                                                     then dbSequenceItem.Seq.Value 
////                                                                     else null
////                                                                 )  
////                                                                 (dbSequenceItem.SearchDatabaseRef
////                                                                 )
////                                                                 (convertToEntityDBSequenceCVParams dbContext dbSequenceItem.CvParams
////                                                                 )
////                                                                 (convertToEntityUserParams dbContext dbSequenceItem.UserParams
////                                                                 )
////                         ) |> List

////    let convertToEntitySequenceCollection  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =    
////        if mzIdentMLXML.SequenceCollection.IsSome 
////           then mzIdentMLXML.SequenceCollection.Value
////                |> (fun sequenceCollectionItem -> createSequenceCollection (convertToEntityPeptides dbContext sequenceCollectionItem.Peptides) 
////                                                                           (convertToEntityPeptideEvidence dbContext sequenceCollectionItem.PeptideEvidences)
////                                                                           (convertToEntityDBSequence dbContext sequenceCollectionItem.DbSequences)
////                   )
////            else createSequenceCollection null null null 

////    let convertToEntityContactRoles  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.ContactRole []) =
////        mzIdentMLXML
////            |> Array.map (fun contactRoleItem -> createContactRole contactRoleItem.ContactRef (convertToEntityRole dbContext contactRoleItem.Role)
////                         ) |> List

////    let convertToEntitySubSamples  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.SubSample []) =
////        mzIdentMLXML
////            |> Array.map (fun subSampleItem -> createSubSample subSampleItem.SampleRef
////                         ) |> List

////    let convertToEntitySampleCVParam  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.CvParam []) =
////        mzIdentMLXML
////            |> Array.map (fun cvParamItem -> createSampleParam (*cvParamItem.Name*)
////                                                               //cvParamItem.Accession 
////                                                               (if cvParamItem.Value.IsSome 
////                                                                   then cvParamItem.Value.Value 
////                                                                   else null
////                                                               )
////                                                               (takeTermID dbContext cvParamItem.CvRef)
////                                                               (if cvParamItem.UnitCvRef.IsSome 
////                                                                   then (takeTermID dbContext cvParamItem.UnitCvRef.Value) 
////                                                                   else null
////                                                               )
////                                                               (if cvParamItem.UnitName.IsSome 
////                                                                   then cvParamItem.UnitName.Value 
////                                                                   else null
////                                                               )
////                         ) |> List

////    let convertToEntitySamples  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.Sample []) =
////        mzIdentMLXML
////            |> Array.map (fun sampleItem -> createSample (sampleItem.Id
////                                                         )
////                                                         //(if sampleItem.Name.IsSome
////                                                         //    then sampleItem.Name.Value
////                                                         //    else null
////                                                         //),
////                                                         (convertToEntityContactRoles dbContext sampleItem.ContactRoles
////                                                         )
////                                                         (convertToEntitySubSamples dbContext sampleItem.SubSamples
////                                                         )
////                                                         (convertToEntitySampleCVParam dbContext sampleItem.CvParams
////                                                         )
////                                                         (convertToEntityUserParams dbContext sampleItem.UserParams
////                                                         )
////                         ) |> List

////    let convertToEntityAnalysisSampleCollection  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =
////        if mzIdentMLXML.AnalysisSampleCollection.IsSome 
////           then mzIdentMLXML.AnalysisSampleCollection.Value
////                |> (fun analysisSampleCollectionItem -> createAnalysisSampleCollection (convertToEntitySamples dbContext analysisSampleCollectionItem.Samples)
////                   )
////           else createAnalysisSampleCollection null

////    let convertToEntityAnalyisCollection  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =
////        mzIdentMLXML.AnalysisCollection
////            |> (fun analyisCollectionItem -> createAnalysisCollection (convertToEntityProteinDetection dbContext analyisCollectionItem.ProteinDetection
////                                                                      )
////                                                                      (convertToEntitySpectrumIdentifications analyisCollectionItem.SpectrumIdentifications
////                                                                      )
////               )

////    let convertToEntityBibliographicReferences (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =
////        mzIdentMLXML.BibliographicReferences
////            |> Array.map (fun bibliographicReferenceItem -> 
////                createBibliographicReference 
////                    (
////                    bibliographicReferenceItem.Id
////                    )
////                    //(if bibliographicReferenceItem.Name.IsSome
////                    //    then bibliographicReferenceItem.Name.Value
////                    //    else null
////                    //)
////                    (if bibliographicReferenceItem.Issue.IsSome
////                        then bibliographicReferenceItem.Issue.Value
////                        else null
////                    )
////                    (if bibliographicReferenceItem.Title.IsSome
////                        then bibliographicReferenceItem.Title.Value
////                        else null
////                    )
////                    (if bibliographicReferenceItem.Pages.IsSome
////                        then bibliographicReferenceItem.Pages.Value
////                        else null
////                    )
////                    (if bibliographicReferenceItem.Volume.IsSome
////                        then bibliographicReferenceItem.Volume.Value
////                        else null
////                    )
////                    (if bibliographicReferenceItem.Doi.IsSome
////                        then bibliographicReferenceItem.Doi.Value
////                        else null
////                    )
////                    (if bibliographicReferenceItem.Editor.IsSome
////                        then bibliographicReferenceItem.Editor.Value
////                        else null
////                    )
////                    (if bibliographicReferenceItem.Publication.IsSome
////                        then bibliographicReferenceItem.Publication.Value
////                        else null
////                    )
////                    (if bibliographicReferenceItem.Publisher.IsSome 
////                        then bibliographicReferenceItem.Publisher.Value
////                        else null
////                    )
////                    (if bibliographicReferenceItem.Year.IsSome
////                        then bibliographicReferenceItem.Year.Value
////                        else -1
////                    )
////                    (if bibliographicReferenceItem.Authors.IsSome
////                        then bibliographicReferenceItem.Authors.Value
////                        else null
////                    )
////                         ) |> List


////    let convertToEntityMzIdentML  (dbContext : DBMSContext) (mzIdentMLXML : SchemePeptideShaker.MzIdentMl) =
////        createMzIdentML (mzIdentMLXML.Id
////                        )
////                        //(if mzIdentMLXML.Name.IsSome 
////                        //    then mzIdentMLXML.Name.Value 
////                        //    else null
////                        //)
////                        (mzIdentMLXML.Version
////                        )
////                        (if mzIdentMLXML.CreationDate.IsSome 
////                            then mzIdentMLXML.CreationDate.Value 
////                            else DateTime.UtcNow
////                        )
////                        (convertToEntityCVList mzIdentMLXML
////                        )
////                        (convertToEntityAnalysisSoftwareList dbContext mzIdentMLXML
////                        )
////                        (convertToEntityProvider dbContext mzIdentMLXML
////                        )
////                        (convertToEntityAuditCollection dbContext mzIdentMLXML
////                        )
////                        (convertToEntityAnalysisSampleCollection dbContext mzIdentMLXML
////                        )
////                        (convertToEntitySequenceCollection dbContext mzIdentMLXML
////                        )
////                        (convertToEntityAnalyisCollection dbContext mzIdentMLXML
////                        )
////                        (convertToEntityAnalysisProtocolCollection dbContext mzIdentMLXML.AnalysisProtocolCollection
////                        )
////                        (convertToEntityDataCollection dbContext mzIdentMLXML.DataCollection
////                        )
////                        (convertToEntityBibliographicReferences mzIdentMLXML
////                        ) 

////    //Testing insertStatements

////    //takeTermEntries
////    convertToEntityCVList (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))

////    let dbMzIdentML = convertToEntityMzIdentML context (SchemePeptideShaker.Load("..\ExampleFile\PeptideShaker_mzid_1_2_example.mzid"))
