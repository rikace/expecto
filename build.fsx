#r @"packages/build/FAKE/tools/FakeLib.dll"

open System
open Fake

Target "Test" ignore

RunTargetOrDefault "Test"