export interface CommonHttpResponse<T> {
    success: boolean;
    httpStatusCode: number;
    message: string;
    data: T;
    metadata?: any; // You can adjust this based on your actual response structure
  }