module ProductFactory 

    open System.Text.RegularExpressions
    open System


    type InputProductLine = { Qty: int; Description: string; LinePrice: decimal; Imported: bool }

    let isImported (productLine: string) = 
        if productLine.Contains("imported") then true, productLine.Replace("imported", "") else false, productLine

    let parseProduct pattern productLine =
        let imported, line = isImported productLine
        let matches = Regex.Match(line, pattern)
        let qty = matches.Groups.[1].Value
        let desc = matches.Groups.[2].Value
        let price = matches.Groups.[3].Value
        {Qty = Convert.ToInt32(qty); Description = desc; LinePrice = Convert.ToDecimal(price); Imported = imported}
      
    let parse line =
        let pattern =  @"^(\d+) (.*) at (.*)$"
        let regex = new Regex(pattern)
        if regex.IsMatch(line) then parseProduct pattern line else failwith "Sorry, not a product line"


