function AxiosRequest(url, method, data, headers, params, responseType) {
    this.url = url;
    this.method = method;
    this.data = data;
    this.headers = headers;
    this.params = params;
    this.responseType = responseType;

    this.toString = function() {
      // implémentation
      return "";
    };
    this.toJSON = function() {
      // implémentation
      return {};
    };
}

function AxiosResponse(status, statusText, headers, config, data) {
    this.status = status;
    this.statusText = statusText;
    this.headers = headers;
    this.config = config;
    this.data = data;

    this.toString = function() {
      // implémentation
      return "";
    };
    this.toJSON = function() {
      // implémentation
      return {};
    };
}

function AxiosError(response, request, name, message, stack, code, isAxiosError) {
    this.response = response;
    this.request = request;
    this.name = name;
    this.message = message;
    this.stack = stack;
    this.code = code;
    this.isAxiosError = isAxiosError;
    this.toString = function() {
      // implémentation
      return "";
    };
    this.toJSON = function() {
      // implémentation
      return {}
    };
}

function AxiosInstance() {
    this.makeRequest = function(config) {
      // implémentation, retourne une Promise
      return new Promise(function(resolve, reject) {
        // implémentation
        resolve();
      })
    };
}

function AxiosStatic() {
    this.makeRequest = function(config) {
    };
    this.create = function(config) {
      // implémentation
      return new AxiosInstance();
    };
    
}

function AxiosRequestConfig(url, method, baseURL, data, headers, params, timeout) {
  this.url = url;
  this.method = method;
  this.baseURL = baseURL;
  this.data = data;
  this.headers = headers;
  this.params = params;
  this.timeout = timeout;

  this.toString = function() {
    // implémentation
    return "";
  };
  this.toJSON = function() {
    // implémentation
    return {};
  };
}

function AxiosResponseConfig(url, status, statusText, headers, config, data, request, response, isAxiosError) {
  this.url = url;
  this.status = status;
  this.statusText = statusText;
  this.headers = headers;
  this.config = config;
  this.data = data;
  this.request = request;
  this.response = response;
  this.isAxiosError = isAxiosError;
  
  this.toString = function() {
    // implémentation
    return "";
  };
  this.toJSON = function() {
    // implémentation
    return {};
  };
}

function AxiosErrorConfig(message, config, code, request, response, isAxiosError) {
  this.message = message;
  this.config = config;
  this.code = code;
  this.request = request;
  this.response = response;
  this.isAxiosError = isAxiosError;

  this.toString = function() {
    // implémentation
    return "";
  }

  this.toJSON = function() {
    // implémentation
    return {};
  }
}

function Cancel(message) {
    this.message = message;
    this.isCancel = true;

    // implémentation
    this.toString = function() {
      // implémentation
      return "";
    };
    this.toJSON = function() {
      // implémentation
      return {};
    };
}

function CancelTokenSource(token, cancel) {
    this.token = CancelToken;
    this.cancel = Cancel;

    // implémentation
    this.toString = function() {
      // implémentation
      return "";
    };
    this.toJSON = function() {
      // implémentation
      return {};
    };
}

function CancelToken(promise, throwIfRequested) {
  this.promise = promise;
  this.throwIfRequested = throwIfRequested;

  // implémentation
  this.toString = function() {
    // implémentation
    return "";
  };
  this.toJSON = function() {
    // implémentation
    return {};
  };

}