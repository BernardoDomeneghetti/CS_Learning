namespace ByteBank.models.enums
{
    public enum ErrorCodeEnum
    {
        // Genéricos (0 - 9)

        NothingToDo                     = 0,
        CreatedFailure                  = 1,
        UpdatedFailure                  = 2,
        UserNotFound                    = 4,
        InvalidFields                   = 5,
        DeleteFailure                   = 6,

        // SMS (10 - 19)

        SmsError                        = 10,
        InvalidToken                    = 11,
        SmsAlreadySended                = 12,

        // Serviços de terceiros (20 - 29)

        ThirdPartyService               = 20,
        
        // Device (30 - 39)

        DeviceUnauthorized               = 30,
        NoDeviceAuthorized               = 31,

        // Pix (40 - 49)

        Portability                     = 40,

        // Voucher (50 - 59)

        VoucherSale                     = 50,

        // Servidor (HttpCodes)

        BadRequest                      = 400,
        Unauthorized                    = 401,
        Forbidden                       = 403,
        NotFound                        = 404,
        NotAllowed                      = 405,
        ServerError                     = 500,
        ServiceUnavailable              = 503,
        GatewayTimeOut                  = 504,
    }
}