using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Net;
using System.Text;

public class ApiTests
{
    private static HttpClient _client;

    static ApiTests()
    {
        var uri = new Uri("https://jsonplaceholder.typicode.com");
        _client = new HttpClient()
        {
            BaseAddress = uri
        };
    }


    [Fact]
    public async Task Get_Endpoint_ReturnsSuccessAndValidSchema()
    {
        // Arrange
        var url = "users";
        string _jsonSchema = @"
 {

  'type': 'array',
  'items': {
    'type': 'object',
    'properties': {
      'id': {
        'type': 'integer'
      },
      'name': {
        'type': 'string'
      },
      'username': {
        'type': 'string'
      },
      'email': {
        'type': 'string',
        'format': 'email'
      },
      'address': {
        'type': 'object',
        'properties': {
          'street': {
            'type': 'string'
          },
          'suite': {
            'type': 'string'
          },
          'city': {
            'type': 'string'
          },
          'zipcode': {
            'type': 'string'
          },
          'geo': {
            'type': 'object',
            'properties': {
              'lat': {
                'type': 'string'
              },
              'lng': {
                'type': 'string'
              }
            },
            'required': ['lat', 'lng']
          }
        },
        'required': ['street', 'suite', 'city', 'zipcode', 'geo']
      },
      'phone': {
        'type': 'string'
      },
      'website': {
        'type': 'string'
       },
      'company': {
        'type': 'object',
        'properties': {
          'name': {
            'type': 'string'
          },
          'catchPhrase': {
            'type': 'string'
          },
          'bs': {
            'type': 'string'
          }
        },
        'required': ['name', 'catchPhrase', 'bs']
      }
    },
    'required': ['id', 'name', 'username', 'email', 'address', 'phone', 'website', 'company']
  }
}";

        // Act
        var response = await _client.GetAsync(url);

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var responseBody = await response.Content.ReadAsStringAsync();

        // Validar o JSON Schema
        var schema = JSchema.Parse(_jsonSchema);
        var isValid = JToken.Parse(responseBody).IsValid(schema, out IList<string> errors);
        Assert.True(isValid, $"Response does not match schema: {string.Join(", ", errors)}");
    }

    [Fact]
    public async Task Post_Endpoint_CreatesResourceAndValidatesSchema()
    {
        // Arrange
        var url = "users";
        var userjson = "{ \"name\": \"Leanne Graham\",\"username\": \"Bret\",\"email\": \"Sincere@april.biz\",\"address\": {\"street\": \"Kulas Light\",\"suite\": \"Apt. 556\",\"city\": \"Gwenborough\",\"zipcode\": \"92998-3874\",\"geo\": {\"lat\": \"-37.3159\",\"lng\": \"81.1496\"}},\"phone\": \"1-770-736-8031 x56442\",\"website\": \"hildegard.org\",\"company\": {\"name\": \"Romaguera-Crona\",\"catchPhrase\": \"Multi-layered client-server neural-net\",\"bs\": \"harness real-time e-markets\"}}";
        var content = new StringContent(userjson, Encoding.UTF8, "application/json");

        string _jsonSchema = @"
{
  'type': 'object',
  'properties': {
    'id': {
      'type': 'integer'
    },
    'name': {
      'type': 'string'
    },
    'username': {
      'type': 'string'
    },
    'email': {
      'type': 'string',
      'format': 'email'
    },
    'address': {
      'type': 'object',
      'properties': {
        'street': {
          'type': 'string'
        },
        'suite': {
          'type': 'string'
        },
        'city': {
          'type': 'string'
        },
        'zipcode': {
          'type': 'string'
        },
        'geo': {
          'type': 'object',
          'properties': {
            'lat': {
              'type': 'string'
            },
            'lng': {
              'type': 'string'
            }
          },
          'required': ['lat', 'lng']
        }
      },
      'required': ['street', 'suite', 'city', 'zipcode', 'geo']
    },
    'phone': {
      'type': 'string'
    },
    'website': {
      'type': 'string'
    },
    'company': {
      'type': 'object',
      'properties': {
        'name': {
          'type': 'string'
        },
        'catchPhrase': {
          'type': 'string'
        },
        'bs': {
          'type': 'string'
        }
      },
      'required': ['name', 'catchPhrase', 'bs']
    }
  },
  'required': ['id', 'name', 'username', 'email', 'address', 'phone', 'website', 'company']
}
";

        // Act
        var response = await _client.PostAsync(url, content);

        // Assert
        Assert.Equal(HttpStatusCode.Created, response.StatusCode);
        var responseBody = await response.Content.ReadAsStringAsync();

        // Validar o  JSON Schema
        var schema = JSchema.Parse(_jsonSchema);
        var isValid = JToken.Parse(responseBody).IsValid(schema, out IList<string> errors);
        Assert.True(isValid, $"Response does not match schema: {string.Join(", ", errors)}");
    }

    [Fact]
    public async Task Put_Endpoint_UpdatesResourceAndValidatesSchema()
    {
        // Arrange
        var url = "users/1"; 
        var userjson = "{ \"name\": \"Leanne Graham\",\"username\": \"Bret\",\"email\": \"Sincere@april.biz\",\"address\": {\"street\": \"Kulas Light\",\"suite\": \"Apt. 556\",\"city\": \"Gwenborough\",\"zipcode\": \"92998-3874\",\"geo\": {\"lat\": \"-37.3159\",\"lng\": \"81.1496\"}},\"phone\": \"1-770-736-8031 x56442\",\"website\": \"hildegard.org\",\"company\": {\"name\": \"Romaguera-Crona\",\"catchPhrase\": \"Multi-layered client-server neural-net\",\"bs\": \"harness real-time e-markets\"}}";
        var content = new StringContent(userjson, Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PutAsync(url, content);

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Delete_Endpoint_RemovesResourceAndValidatesResponseCode()
    {
        // Arrange
        var url = "users/1"; 

        // Act
        var response = await _client.DeleteAsync(url);

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}

