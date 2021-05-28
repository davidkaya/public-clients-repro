# Configuration for generating REST client

> see https://aka.ms/autorest

This file is in `Literate` file format ([CommonMark](http://spec.commonmark.org/)) which means it has embedded `code-blocks`. Those code blocks are used by `autorest` code generation tool.

To generate client call `autorest` in the folder with this `README.md` file.


## API Specification file

``` yaml
input-file: petstore.yaml
csharp:
  public-clients: true
```