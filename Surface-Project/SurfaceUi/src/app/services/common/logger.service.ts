import { Injectable } from '@angular/core';
import { LoggerConfig } from '../../models/LoggerConfig';

@Injectable({
  providedIn: 'root'
})
export class LoggerService {
  private config: LoggerConfig = {
    enableLogging: true,
    logLevel: 'log',
    logToConsole: true,
    logToServer: false
  };

  private enableLogging = true;
  private logLevel: 'log' | 'error' | 'warn' | 'info' | 'debug' = 'log';
  private logToConsole = true;
  private logToServer = false;

   configure(enableLogging: boolean, logLevel: 'log' | 'error' | 'warn' | 'info' | 'debug' = 'log', logToConsole: boolean = true, logToServer: boolean = false): void {
    this.enableLogging = enableLogging;
    this.logLevel = logLevel;
    this.logToConsole = logToConsole;
    this.logToServer = logToServer;
  }

  log(message: string): void {
    this.logMessage('log', message);
  }

  error(message: string): void {
    this.logMessage('error', message);
  }

  warn(message: string): void {
    this.logMessage('warn', message);
  }

  info(message: string): void {
    this.logMessage('info', message);
  }

  debug(message: string): void {
    this.logMessage('debug', message);
  }

  private logMessage(level: 'log' | 'error' | 'warn' | 'info' | 'debug', message: string): void {
    if (this.enableLogging && level === this.logLevel) {
      if (this.logToConsole) {
        console[level](message);
      }
    }
  }
}