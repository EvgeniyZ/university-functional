module Domain

open System

type StudentId = StudentId of int
type AdmissionYear = AdmissionYear of DateTime
type ReleaseYear = ReleaseYear of DateTime
type StudentAge = private StudentAge of int

module StudentAge =
    let private minimumAge = 15
    let private maximumAge = 120

    let create age =
        if age < minimumAge
        then printf "StudentAge must be greater than %i" minimumAge |> Error
        else if age > maximumAge
        then printf "StudentAge must be less than %i" maximumAge |> Error
        else StudentAge age |> Ok

type CourseId = CourseId of int

type Student =
    { Id: StudentId
      FirstName: string
      LastName: string
      Age: StudentAge
      CourseId: CourseId
      AdmissionYear: AdmissionYear
      ReleaseYear: ReleaseYear }

type Course =
    { Id: CourseId
      Name: string
      StudentIds: StudentId list }