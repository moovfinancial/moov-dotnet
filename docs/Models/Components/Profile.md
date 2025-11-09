# Profile

Describes a Moov account profile. A profile will have a business, individual, or guest depending on the account's type.


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Individual`                                                      | [IndividualProfile](../../Models/Components/IndividualProfile.md) | :heavy_minus_sign:                                                | Describes an individual.                                          |
| `Business`                                                        | [BusinessProfile](../../Models/Components/BusinessProfile.md)     | :heavy_minus_sign:                                                | Describes a business.                                             |
| `Guest`                                                           | [GuestProfile](../../Models/Components/GuestProfile.md)           | :heavy_minus_sign:                                                | Describes a guest account profile.                                |