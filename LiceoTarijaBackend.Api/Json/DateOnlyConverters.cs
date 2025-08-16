using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LiceoTarijaBackend.Api.Json;

// Converters para System.Text.Json en .NET 8

public sealed class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var s = reader.GetString();
            if (DateOnly.TryParse(s, out var d)) return d;
            if (DateTime.TryParse(s, out var dt)) return DateOnly.FromDateTime(dt);
        }
        throw new JsonException("Formato de DateOnly inválido. Usa 'yyyy-MM-dd'.");
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString("yyyy-MM-dd"));
}

public sealed class NullableDateOnlyJsonConverter : JsonConverter<DateOnly?>
{
    public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => reader.TokenType == JsonTokenType.Null ? null : new DateOnlyJsonConverter().Read(ref reader, typeof(DateOnly), options);

    public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
    {
        if (value is null) { writer.WriteNullValue(); return; }
        new DateOnlyJsonConverter().Write(writer, value.Value, options);
    }
}

public sealed class TimeOnlyJsonConverter : JsonConverter<TimeOnly>
{
    public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var s = reader.GetString();
        if (TimeOnly.TryParse(s, out var t)) return t;
        throw new JsonException("Formato de TimeOnly inválido. Usa 'HH:mm:ss'.");
    }

    public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
        => writer.WriteStringValue(value.ToString("HH:mm:ss"));
}

public sealed class NullableTimeOnlyJsonConverter : JsonConverter<TimeOnly?>
{
    public override TimeOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        => reader.TokenType == JsonTokenType.Null ? null : new TimeOnlyJsonConverter().Read(ref reader, typeof(TimeOnly), options);

    public override void Write(Utf8JsonWriter writer, TimeOnly? value, JsonSerializerOptions options)
    {
        if (value is null) { writer.WriteNullValue(); return; }
        new TimeOnlyJsonConverter().Write(writer, value.Value, options);
    }
}

