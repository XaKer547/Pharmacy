﻿
using System.Text.Json;

namespace PharmacyApi.Data.Entities.Seeder
{
    public partial class DbSeeder
    {
        public void SeedAll(PharmacyDbContext context)
        {
            SeedManufacturerAsync(context).GetAwaiter().GetResult();

            SeedTradeNamesAsync(context).GetAwaiter().GetResult();

            SeedMedicinesAsync(context).GetAwaiter().GetResult();
        }

        private async Task SeedMedicinesAsync(PharmacyDbContext context)
        {
            if (context.Medicines.Any())
                return;

            var json = "[\r\n    {\r\n        \"Name\": \"Амиксин\",\r\n        \"TradeNameId\": 1,\r\n        \"ManufacturerId\": 1,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/579/600_600_photo_es_521BB6C6-98AB-44A6-8EE0-C7B07D9C6E15.jpg\",\r\n        \"Price\": 127,\r\n        \"StockQuantity\": 95,\r\n        \"OptimalQuantity\": 135,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Арбидол\",\r\n        \"TradeNameId\": 2,\r\n        \"ManufacturerId\": 2,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/5c6/600_600_photo_es_9779A271-04D2-43B8-949F-9BEF64AB647A.jpg\",\r\n        \"Price\": 83,\r\n        \"StockQuantity\": 43,\r\n        \"OptimalQuantity\": 148,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Анаферон\",\r\n        \"TradeNameId\": 3,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/bc2/600_600_photo_es_FF0A881E-0776-47CC-91DB-E60B41BADAFD.jpg\",\r\n        \"Price\": 100,\r\n        \"StockQuantity\": 181,\r\n        \"OptimalQuantity\": 182,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Циклоферон\",\r\n        \"TradeNameId\": 4,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/374/600_600_photo_es_DB5D5603-8D5B-4A2E-AA9A-AE2AE584F12D.jpg\",\r\n        \"Price\": 190,\r\n        \"StockQuantity\": 177,\r\n        \"OptimalQuantity\": 103,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Ремантадин\",\r\n        \"TradeNameId\": 5,\r\n        \"ManufacturerId\": 2,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/22b/ad8/600_600_photo_es.jpg\",\r\n        \"Price\": 118,\r\n        \"StockQuantity\": 95,\r\n        \"OptimalQuantity\": 28,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Кагоцел\",\r\n        \"TradeNameId\": 6,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c34/600_600_photo_es_D875DF4F-3A76-4BEB-89A1-DF358BD5538A.jpg\",\r\n        \"Price\": 142,\r\n        \"StockQuantity\": 95,\r\n        \"OptimalQuantity\": 59,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Ибуклин\",\r\n        \"TradeNameId\": 7,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/d9c/600_600_photo_es_D7723793-30A1-78BE-9E05-30100007FF33.jpg\",\r\n        \"Price\": 63,\r\n        \"StockQuantity\": 105,\r\n        \"OptimalQuantity\": 43,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Нурофен\",\r\n        \"TradeNameId\": 8,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/d4c/600_600_photo_es_27362CB7-989F-48A2-B1C7-CF4307474E2E.jpg\",\r\n        \"Price\": 148,\r\n        \"StockQuantity\": 171,\r\n        \"OptimalQuantity\": 54,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Панадол\",\r\n        \"TradeNameId\": 9,\r\n        \"ManufacturerId\": 5,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/f45/600_600_photo_es_E5C5EB0E-9A5D-4851-9160-34814A7B6AC0.jpg\",\r\n        \"Price\": 81,\r\n        \"StockQuantity\": 181,\r\n        \"OptimalQuantity\": 185,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Терафлю\",\r\n        \"TradeNameId\": 10,\r\n        \"ManufacturerId\": 6,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/8d6/600_600_photo_es_CD3DB482-D461-4C2A-A812-FB1616791DE2.jpg\",\r\n        \"Price\": 162,\r\n        \"StockQuantity\": 129,\r\n        \"OptimalQuantity\": 38,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Фервекс\",\r\n        \"TradeNameId\": 11,\r\n        \"ManufacturerId\": 7,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/56d/600_600_photo_es.jpg\",\r\n        \"Price\": 62,\r\n        \"StockQuantity\": 198,\r\n        \"OptimalQuantity\": 29,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Амоксициллин\",\r\n        \"TradeNameId\": 12,\r\n        \"ManufacturerId\": 8,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/713/600_600_photo_es_CE31BC8C-C1A1-A9D2-AE05-3DE0A030A352.jpg\",\r\n        \"Price\": 14,\r\n        \"StockQuantity\": 139,\r\n        \"OptimalQuantity\": 117,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Ципрофлоксаци\",\r\n        \"TradeNameId\": 13,\r\n        \"ManufacturerId\": 9,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/eb6/600_600_photo_es_FD7DD000-C2BF-4F92-9D6F-70F1108BF9C7.jpg\",\r\n        \"Price\": 62,\r\n        \"StockQuantity\": 79,\r\n        \"OptimalQuantity\": 38,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Лоратадин\",\r\n        \"TradeNameId\": 14,\r\n        \"ManufacturerId\": 10,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/ca4/11b/600_600_photo_es.jpg\",\r\n        \"Price\": 83,\r\n        \"StockQuantity\": 22,\r\n        \"OptimalQuantity\": 53,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Омепразол\",\r\n        \"TradeNameId\": 15,\r\n        \"ManufacturerId\": 11,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/084/600_600_photo_es_FBC75DB6-49A1-41D1-809D-266B25782BD0.jpg\",\r\n        \"Price\": 114,\r\n        \"StockQuantity\": 91,\r\n        \"OptimalQuantity\": 109,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Панкреатин\",\r\n        \"TradeNameId\": 16,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/fd4/600_600_photo_es_98862210-0686-F154-BE05-3E40A030AF31.jpg\",\r\n        \"Price\": 50,\r\n        \"StockQuantity\": 67,\r\n        \"OptimalQuantity\": 166,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Супрастин\",\r\n        \"TradeNameId\": 17,\r\n        \"ManufacturerId\": 13,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/147/600_600_photo_es_7125A9E6-6D64-E659-0E05-3E30A030AD94.jpg\",\r\n        \"Price\": 195,\r\n        \"StockQuantity\": 179,\r\n        \"OptimalQuantity\": 105,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Но-шпа\",\r\n        \"TradeNameId\": 18,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/2bb/600_600_photo_es_9F325EF7-8025-4A9F-8B50-D1862D582A76.jpg\",\r\n        \"Price\": 63,\r\n        \"StockQuantity\": 94,\r\n        \"OptimalQuantity\": 196,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Линекс\",\r\n        \"TradeNameId\": 19,\r\n        \"ManufacturerId\": 14,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/26b/600_600_photo_es_6DE85906-120A-4004-99F4-D202108B95F5.png\",\r\n        \"Price\": 20,\r\n        \"StockQuantity\": 33,\r\n        \"OptimalQuantity\": 143,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Валокордин\",\r\n        \"TradeNameId\": 20,\r\n        \"ManufacturerId\": 15,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c00/151/600_600_photo_es.jpg\",\r\n        \"Price\": 175,\r\n        \"StockQuantity\": 190,\r\n        \"OptimalQuantity\": 68,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Аспирин\",\r\n        \"TradeNameId\": 21,\r\n        \"ManufacturerId\": 9,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/b74/600_600_photo_es_CE31BC8C-C1A0-B9D2-AE05-3DE0A030A352.jpg\",\r\n        \"Price\": 43,\r\n        \"StockQuantity\": 120,\r\n        \"OptimalQuantity\": 112,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Парацетамол\",\r\n        \"TradeNameId\": 9,\r\n        \"ManufacturerId\": 5,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/239/600_600_photo_es_EF32AC17-7D94-B488-7E05-30100007F625.jpg\",\r\n        \"Price\": 10,\r\n        \"StockQuantity\": 117,\r\n        \"OptimalQuantity\": 100,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Ибупрофен\",\r\n        \"TradeNameId\": 8,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c05/600_600_photo_es_3DEBA363-3D55-3224-0E05-30100007F2D7.jpg\",\r\n        \"Price\": 141,\r\n        \"StockQuantity\": 183,\r\n        \"OptimalQuantity\": 170,\r\n        \"WarehouseId\": 1\r\n    },\r\n    {\r\n        \"Name\": \"Амиксин\",\r\n        \"TradeNameId\": 1,\r\n        \"ManufacturerId\": 1,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/579/600_600_photo_es_521BB6C6-98AB-44A6-8EE0-C7B07D9C6E15.jpg\",\r\n        \"Price\": 84,\r\n        \"StockQuantity\": 149,\r\n        \"OptimalQuantity\": 134,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Арбидол\",\r\n        \"TradeNameId\": 2,\r\n        \"ManufacturerId\": 2,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/5c6/600_600_photo_es_9779A271-04D2-43B8-949F-9BEF64AB647A.jpg\",\r\n        \"Price\": 115,\r\n        \"StockQuantity\": 180,\r\n        \"OptimalQuantity\": 19,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Анаферон\",\r\n        \"TradeNameId\": 3,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/bc2/600_600_photo_es_FF0A881E-0776-47CC-91DB-E60B41BADAFD.jpg\",\r\n        \"Price\": 101,\r\n        \"StockQuantity\": 121,\r\n        \"OptimalQuantity\": 33,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Циклоферон\",\r\n        \"TradeNameId\": 4,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/374/600_600_photo_es_DB5D5603-8D5B-4A2E-AA9A-AE2AE584F12D.jpg\",\r\n        \"Price\": 104,\r\n        \"StockQuantity\": 163,\r\n        \"OptimalQuantity\": 126,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Ремантадин\",\r\n        \"TradeNameId\": 5,\r\n        \"ManufacturerId\": 2,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/22b/ad8/600_600_photo_es.jpg\",\r\n        \"Price\": 195,\r\n        \"StockQuantity\": 62,\r\n        \"OptimalQuantity\": 180,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Кагоцел\",\r\n        \"TradeNameId\": 6,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c34/600_600_photo_es_D875DF4F-3A76-4BEB-89A1-DF358BD5538A.jpg\",\r\n        \"Price\": 47,\r\n        \"StockQuantity\": 23,\r\n        \"OptimalQuantity\": 29,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Ибуклин\",\r\n        \"TradeNameId\": 7,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/d9c/600_600_photo_es_D7723793-30A1-78BE-9E05-30100007FF33.jpg\",\r\n        \"Price\": 104,\r\n        \"StockQuantity\": 160,\r\n        \"OptimalQuantity\": 117,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Нурофен\",\r\n        \"TradeNameId\": 8,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/d4c/600_600_photo_es_27362CB7-989F-48A2-B1C7-CF4307474E2E.jpg\",\r\n        \"Price\": 105,\r\n        \"StockQuantity\": 20,\r\n        \"OptimalQuantity\": 14,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Панадол\",\r\n        \"TradeNameId\": 9,\r\n        \"ManufacturerId\": 5,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/f45/600_600_photo_es_E5C5EB0E-9A5D-4851-9160-34814A7B6AC0.jpg\",\r\n        \"Price\": 193,\r\n        \"StockQuantity\": 198,\r\n        \"OptimalQuantity\": 98,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Терафлю\",\r\n        \"TradeNameId\": 10,\r\n        \"ManufacturerId\": 6,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/8d6/600_600_photo_es_CD3DB482-D461-4C2A-A812-FB1616791DE2.jpg\",\r\n        \"Price\": 173,\r\n        \"StockQuantity\": 126,\r\n        \"OptimalQuantity\": 161,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Фервекс\",\r\n        \"TradeNameId\": 11,\r\n        \"ManufacturerId\": 7,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/56d/600_600_photo_es.jpg\",\r\n        \"Price\": 140,\r\n        \"StockQuantity\": 148,\r\n        \"OptimalQuantity\": 67,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Амоксициллин\",\r\n        \"TradeNameId\": 12,\r\n        \"ManufacturerId\": 8,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/713/600_600_photo_es_CE31BC8C-C1A1-A9D2-AE05-3DE0A030A352.jpg\",\r\n        \"Price\": 79,\r\n        \"StockQuantity\": 151,\r\n        \"OptimalQuantity\": 172,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Ципрофлоксаци\",\r\n        \"TradeNameId\": 13,\r\n        \"ManufacturerId\": 9,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/eb6/600_600_photo_es_FD7DD000-C2BF-4F92-9D6F-70F1108BF9C7.jpg\",\r\n        \"Price\": 185,\r\n        \"StockQuantity\": 94,\r\n        \"OptimalQuantity\": 82,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Лоратадин\",\r\n        \"TradeNameId\": 14,\r\n        \"ManufacturerId\": 10,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/ca4/11b/600_600_photo_es.jpg\",\r\n        \"Price\": 54,\r\n        \"StockQuantity\": 153,\r\n        \"OptimalQuantity\": 21,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Омепразол\",\r\n        \"TradeNameId\": 15,\r\n        \"ManufacturerId\": 11,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/084/600_600_photo_es_FBC75DB6-49A1-41D1-809D-266B25782BD0.jpg\",\r\n        \"Price\": 99,\r\n        \"StockQuantity\": 23,\r\n        \"OptimalQuantity\": 194,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Панкреатин\",\r\n        \"TradeNameId\": 16,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/fd4/600_600_photo_es_98862210-0686-F154-BE05-3E40A030AF31.jpg\",\r\n        \"Price\": 198,\r\n        \"StockQuantity\": 68,\r\n        \"OptimalQuantity\": 157,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Фестал\",\r\n        \"TradeNameId\": 22,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/bf6/600_600_photo_es_D6EB4E65-552F-DB66-EE05-30100007F99D.jpg\",\r\n        \"Price\": 90,\r\n        \"StockQuantity\": 20,\r\n        \"OptimalQuantity\": 171,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Супрастин\",\r\n        \"TradeNameId\": 17,\r\n        \"ManufacturerId\": 13,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/147/600_600_photo_es_7125A9E6-6D64-E659-0E05-3E30A030AD94.jpg\",\r\n        \"Price\": 20,\r\n        \"StockQuantity\": 125,\r\n        \"OptimalQuantity\": 131,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Но-шпа\",\r\n        \"TradeNameId\": 18,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/2bb/600_600_photo_es_9F325EF7-8025-4A9F-8B50-D1862D582A76.jpg\",\r\n        \"Price\": 195,\r\n        \"StockQuantity\": 113,\r\n        \"OptimalQuantity\": 192,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Линекс\",\r\n        \"TradeNameId\": 19,\r\n        \"ManufacturerId\": 14,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/26b/600_600_photo_es_6DE85906-120A-4004-99F4-D202108B95F5.png\",\r\n        \"Price\": 165,\r\n        \"StockQuantity\": 181,\r\n        \"OptimalQuantity\": 126,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Валокордин\",\r\n        \"TradeNameId\": 20,\r\n        \"ManufacturerId\": 15,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c00/151/600_600_photo_es.jpg\",\r\n        \"Price\": 129,\r\n        \"StockQuantity\": 87,\r\n        \"OptimalQuantity\": 165,\r\n        \"WarehouseId\": 2\r\n    },\r\n    {\r\n        \"Name\": \"Арбидол\",\r\n        \"TradeNameId\": 2,\r\n        \"ManufacturerId\": 2,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/5c6/600_600_photo_es_9779A271-04D2-43B8-949F-9BEF64AB647A.jpg\",\r\n        \"Price\": 42,\r\n        \"StockQuantity\": 73,\r\n        \"OptimalQuantity\": 189,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Анаферон\",\r\n        \"TradeNameId\": 3,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/bc2/600_600_photo_es_FF0A881E-0776-47CC-91DB-E60B41BADAFD.jpg\",\r\n        \"Price\": 41,\r\n        \"StockQuantity\": 189,\r\n        \"OptimalQuantity\": 182,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Циклоферон\",\r\n        \"TradeNameId\": 4,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/374/600_600_photo_es_DB5D5603-8D5B-4A2E-AA9A-AE2AE584F12D.jpg\",\r\n        \"Price\": 19,\r\n        \"StockQuantity\": 57,\r\n        \"OptimalQuantity\": 168,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Ремантадин\",\r\n        \"TradeNameId\": 5,\r\n        \"ManufacturerId\": 2,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/22b/ad8/600_600_photo_es.jpg\",\r\n        \"Price\": 41,\r\n        \"StockQuantity\": 184,\r\n        \"OptimalQuantity\": 136,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Кагоцел\",\r\n        \"TradeNameId\": 6,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c34/600_600_photo_es_D875DF4F-3A76-4BEB-89A1-DF358BD5538A.jpg\",\r\n        \"Price\": 180,\r\n        \"StockQuantity\": 116,\r\n        \"OptimalQuantity\": 89,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Ибуклин\",\r\n        \"TradeNameId\": 7,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/d9c/600_600_photo_es_D7723793-30A1-78BE-9E05-30100007FF33.jpg\",\r\n        \"Price\": 198,\r\n        \"StockQuantity\": 147,\r\n        \"OptimalQuantity\": 177,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Нурофен\",\r\n        \"TradeNameId\": 8,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/d4c/600_600_photo_es_27362CB7-989F-48A2-B1C7-CF4307474E2E.jpg\",\r\n        \"Price\": 195,\r\n        \"StockQuantity\": 62,\r\n        \"OptimalQuantity\": 79,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Панадол\",\r\n        \"TradeNameId\": 9,\r\n        \"ManufacturerId\": 5,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/f45/600_600_photo_es_E5C5EB0E-9A5D-4851-9160-34814A7B6AC0.jpg\",\r\n        \"Price\": 67,\r\n        \"StockQuantity\": 117,\r\n        \"OptimalQuantity\": 124,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Терафлю\",\r\n        \"TradeNameId\": 10,\r\n        \"ManufacturerId\": 6,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/8d6/600_600_photo_es_CD3DB482-D461-4C2A-A812-FB1616791DE2.jpg\",\r\n        \"Price\": 114,\r\n        \"StockQuantity\": 187,\r\n        \"OptimalQuantity\": 187,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Фервекс\",\r\n        \"TradeNameId\": 11,\r\n        \"ManufacturerId\": 7,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/56d/600_600_photo_es.jpg\",\r\n        \"Price\": 94,\r\n        \"StockQuantity\": 41,\r\n        \"OptimalQuantity\": 131,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Амоксициллин\",\r\n        \"TradeNameId\": 12,\r\n        \"ManufacturerId\": 8,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/713/600_600_photo_es_CE31BC8C-C1A1-A9D2-AE05-3DE0A030A352.jpg\",\r\n        \"Price\": 34,\r\n        \"StockQuantity\": 184,\r\n        \"OptimalQuantity\": 100,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Ципрофлоксаци\",\r\n        \"TradeNameId\": 13,\r\n        \"ManufacturerId\": 9,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/eb6/600_600_photo_es_FD7DD000-C2BF-4F92-9D6F-70F1108BF9C7.jpg\",\r\n        \"Price\": 156,\r\n        \"StockQuantity\": 57,\r\n        \"OptimalQuantity\": 162,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Лоратадин\",\r\n        \"TradeNameId\": 14,\r\n        \"ManufacturerId\": 10,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/ca4/11b/600_600_photo_es.jpg\",\r\n        \"Price\": 154,\r\n        \"StockQuantity\": 80,\r\n        \"OptimalQuantity\": 29,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Омепразол\",\r\n        \"TradeNameId\": 15,\r\n        \"ManufacturerId\": 11,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/084/600_600_photo_es_FBC75DB6-49A1-41D1-809D-266B25782BD0.jpg\",\r\n        \"Price\": 173,\r\n        \"StockQuantity\": 144,\r\n        \"OptimalQuantity\": 191,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Панкреатин\",\r\n        \"TradeNameId\": 16,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/fd4/600_600_photo_es_98862210-0686-F154-BE05-3E40A030AF31.jpg\",\r\n        \"Price\": 87,\r\n        \"StockQuantity\": 82,\r\n        \"OptimalQuantity\": 136,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Фестал\",\r\n        \"TradeNameId\": 22,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/bf6/600_600_photo_es_D6EB4E65-552F-DB66-EE05-30100007F99D.jpg\",\r\n        \"Price\": 37,\r\n        \"StockQuantity\": 60,\r\n        \"OptimalQuantity\": 166,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Но-шпа\",\r\n        \"TradeNameId\": 18,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/2bb/600_600_photo_es_9F325EF7-8025-4A9F-8B50-D1862D582A76.jpg\",\r\n        \"Price\": 84,\r\n        \"StockQuantity\": 19,\r\n        \"OptimalQuantity\": 200,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Линекс\",\r\n        \"TradeNameId\": 19,\r\n        \"ManufacturerId\": 14,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/26b/600_600_photo_es_6DE85906-120A-4004-99F4-D202108B95F5.png\",\r\n        \"Price\": 82,\r\n        \"StockQuantity\": 64,\r\n        \"OptimalQuantity\": 36,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Валокордин\",\r\n        \"TradeNameId\": 20,\r\n        \"ManufacturerId\": 15,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c00/151/600_600_photo_es.jpg\",\r\n        \"Price\": 175,\r\n        \"StockQuantity\": 84,\r\n        \"OptimalQuantity\": 52,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Парацетамол\",\r\n        \"TradeNameId\": 9,\r\n        \"ManufacturerId\": 5,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/239/600_600_photo_es_EF32AC17-7D94-B488-7E05-30100007F625.jpg\",\r\n        \"Price\": 32,\r\n        \"StockQuantity\": 142,\r\n        \"OptimalQuantity\": 87,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Ибупрофен\",\r\n        \"TradeNameId\": 8,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c05/600_600_photo_es_3DEBA363-3D55-3224-0E05-30100007F2D7.jpg\",\r\n        \"Price\": 49,\r\n        \"StockQuantity\": 62,\r\n        \"OptimalQuantity\": 186,\r\n        \"WarehouseId\": 3\r\n    },\r\n    {\r\n        \"Name\": \"Амиксин\",\r\n        \"TradeNameId\": 1,\r\n        \"ManufacturerId\": 1,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/579/600_600_photo_es_521BB6C6-98AB-44A6-8EE0-C7B07D9C6E15.jpg\",\r\n        \"Price\": 162,\r\n        \"StockQuantity\": 125,\r\n        \"OptimalQuantity\": 170,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Арбидол\",\r\n        \"TradeNameId\": 2,\r\n        \"ManufacturerId\": 2,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/5c6/600_600_photo_es_9779A271-04D2-43B8-949F-9BEF64AB647A.jpg\",\r\n        \"Price\": 129,\r\n        \"StockQuantity\": 116,\r\n        \"OptimalQuantity\": 88,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Анаферон\",\r\n        \"TradeNameId\": 3,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/bc2/600_600_photo_es_FF0A881E-0776-47CC-91DB-E60B41BADAFD.jpg\",\r\n        \"Price\": 169,\r\n        \"StockQuantity\": 190,\r\n        \"OptimalQuantity\": 116,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Циклоферон\",\r\n        \"TradeNameId\": 4,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/374/600_600_photo_es_DB5D5603-8D5B-4A2E-AA9A-AE2AE584F12D.jpg\",\r\n        \"Price\": 165,\r\n        \"StockQuantity\": 131,\r\n        \"OptimalQuantity\": 184,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Ремантадин\",\r\n        \"TradeNameId\": 5,\r\n        \"ManufacturerId\": 2,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/22b/ad8/600_600_photo_es.jpg\",\r\n        \"Price\": 80,\r\n        \"StockQuantity\": 51,\r\n        \"OptimalQuantity\": 133,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Кагоцел\",\r\n        \"TradeNameId\": 6,\r\n        \"ManufacturerId\": 3,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c34/600_600_photo_es_D875DF4F-3A76-4BEB-89A1-DF358BD5538A.jpg\",\r\n        \"Price\": 17,\r\n        \"StockQuantity\": 114,\r\n        \"OptimalQuantity\": 144,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Ибуклин\",\r\n        \"TradeNameId\": 7,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/d9c/600_600_photo_es_D7723793-30A1-78BE-9E05-30100007FF33.jpg\",\r\n        \"Price\": 190,\r\n        \"StockQuantity\": 197,\r\n        \"OptimalQuantity\": 160,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Нурофен\",\r\n        \"TradeNameId\": 8,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/d4c/600_600_photo_es_27362CB7-989F-48A2-B1C7-CF4307474E2E.jpg\",\r\n        \"Price\": 184,\r\n        \"StockQuantity\": 48,\r\n        \"OptimalQuantity\": 174,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Панадол\",\r\n        \"TradeNameId\": 9,\r\n        \"ManufacturerId\": 5,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/f45/600_600_photo_es_E5C5EB0E-9A5D-4851-9160-34814A7B6AC0.jpg\",\r\n        \"Price\": 90,\r\n        \"StockQuantity\": 69,\r\n        \"OptimalQuantity\": 18,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Терафлю\",\r\n        \"TradeNameId\": 10,\r\n        \"ManufacturerId\": 6,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/8d6/600_600_photo_es_CD3DB482-D461-4C2A-A812-FB1616791DE2.jpg\",\r\n        \"Price\": 185,\r\n        \"StockQuantity\": 110,\r\n        \"OptimalQuantity\": 170,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Лоратадин\",\r\n        \"TradeNameId\": 14,\r\n        \"ManufacturerId\": 10,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/ca4/11b/600_600_photo_es.jpg\",\r\n        \"Price\": 173,\r\n        \"StockQuantity\": 72,\r\n        \"OptimalQuantity\": 164,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Омепразол\",\r\n        \"TradeNameId\": 15,\r\n        \"ManufacturerId\": 11,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/084/600_600_photo_es_FBC75DB6-49A1-41D1-809D-266B25782BD0.jpg\",\r\n        \"Price\": 191,\r\n        \"StockQuantity\": 47,\r\n        \"OptimalQuantity\": 172,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Панкреатин\",\r\n        \"TradeNameId\": 16,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/fd4/600_600_photo_es_98862210-0686-F154-BE05-3E40A030AF31.jpg\",\r\n        \"Price\": 82,\r\n        \"StockQuantity\": 34,\r\n        \"OptimalQuantity\": 140,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Фестал\",\r\n        \"TradeNameId\": 22,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/bf6/600_600_photo_es_D6EB4E65-552F-DB66-EE05-30100007F99D.jpg\",\r\n        \"Price\": 74,\r\n        \"StockQuantity\": 94,\r\n        \"OptimalQuantity\": 109,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Супрастин\",\r\n        \"TradeNameId\": 17,\r\n        \"ManufacturerId\": 13,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/147/600_600_photo_es_7125A9E6-6D64-E659-0E05-3E30A030AD94.jpg\",\r\n        \"Price\": 198,\r\n        \"StockQuantity\": 27,\r\n        \"OptimalQuantity\": 66,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Но-шпа\",\r\n        \"TradeNameId\": 18,\r\n        \"ManufacturerId\": 12,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/2bb/600_600_photo_es_9F325EF7-8025-4A9F-8B50-D1862D582A76.jpg\",\r\n        \"Price\": 134,\r\n        \"StockQuantity\": 55,\r\n        \"OptimalQuantity\": 182,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Линекс\",\r\n        \"TradeNameId\": 19,\r\n        \"ManufacturerId\": 14,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/26b/600_600_photo_es_6DE85906-120A-4004-99F4-D202108B95F5.png\",\r\n        \"Price\": 53,\r\n        \"StockQuantity\": 68,\r\n        \"OptimalQuantity\": 58,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Валокордин\",\r\n        \"TradeNameId\": 20,\r\n        \"ManufacturerId\": 15,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c00/151/600_600_photo_es.jpg\",\r\n        \"Price\": 73,\r\n        \"StockQuantity\": 175,\r\n        \"OptimalQuantity\": 182,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Аспирин\",\r\n        \"TradeNameId\": 21,\r\n        \"ManufacturerId\": 9,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/b74/600_600_photo_es_CE31BC8C-C1A0-B9D2-AE05-3DE0A030A352.jpg\",\r\n        \"Price\": 152,\r\n        \"StockQuantity\": 64,\r\n        \"OptimalQuantity\": 167,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Парацетамол\",\r\n        \"TradeNameId\": 9,\r\n        \"ManufacturerId\": 5,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/239/600_600_photo_es_EF32AC17-7D94-B488-7E05-30100007F625.jpg\",\r\n        \"Price\": 12,\r\n        \"StockQuantity\": 103,\r\n        \"OptimalQuantity\": 31,\r\n        \"WarehouseId\": 4\r\n    },\r\n    {\r\n        \"Name\": \"Ибупрофен\",\r\n        \"TradeNameId\": 8,\r\n        \"ManufacturerId\": 4,\r\n        \"Image\": \"https://static.zdravcity.ru/upload/iblock/c05/600_600_photo_es_3DEBA363-3D55-3224-0E05-30100007F2D7.jpg\",\r\n        \"Price\": 119,\r\n        \"StockQuantity\": 99,\r\n        \"OptimalQuantity\": 127,\r\n        \"WarehouseId\": 4\r\n    }\r\n]";

            var medicines = JsonSerializer.Deserialize<IReadOnlyCollection<Medicine>>(json);

            context.Medicines.AddRange(medicines);

            await context.SaveChangesAsync();
        }
    }
}
