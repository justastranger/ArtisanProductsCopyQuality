# ArtisanProductsCopyQuality

This mod replicates Quality Artisan Products in a way that cuts out the need to rewrite recipes.

## Configuration

With GMCM, you can edit the config from the title screen.

There is only one text box, values must be separated by a semicolon but whitespace is optional (it gets trimmed).

### Config File

The `config.json` file consists of one property: A list of Qualified Item IDs corresponding to each Machine's Object.

By default the file looks like this:
```json
{
  "machinesToTarget": [
    "(BC)17",
    "(BC)12",
    "(BC)15",
    "(BC)16",
    "(BC)24",
    "(BC)19",
    "(BC)Dehydrator",
    "(BC)FishSmoker"
  ]
}
```