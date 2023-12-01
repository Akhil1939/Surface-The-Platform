export interface LoggerConfig {
    enableLogging: boolean;
    logLevel: 'log' | 'error' | 'warn' | 'info' | 'debug';
    logToConsole: boolean;
    logToServer: boolean;
}