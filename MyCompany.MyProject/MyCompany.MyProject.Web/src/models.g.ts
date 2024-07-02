import * as metadata from './metadata.g'
import { Model, DataSource, convertToModel, mapToModel } from 'coalesce-vue/lib/model'

export interface ApplicationUser extends Model<typeof metadata.ApplicationUser> {
  applicationUserId: string | null
  name: string | null
  email: string | null
  organizationId: string | null
  organization: Organization | null
}
export class ApplicationUser {
  
  /** Mutates the input object and its descendents into a valid ApplicationUser implementation. */
  static convert(data?: Partial<ApplicationUser>): ApplicationUser {
    return convertToModel(data || {}, metadata.ApplicationUser) 
  }
  
  /** Maps the input object and its descendents to a new, valid ApplicationUser implementation. */
  static map(data?: Partial<ApplicationUser>): ApplicationUser {
    return mapToModel(data || {}, metadata.ApplicationUser) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.ApplicationUser; }
  
  /** Instantiate a new ApplicationUser, optionally basing it on the given data. */
  constructor(data?: Partial<ApplicationUser> | {[k: string]: any}) {
    Object.assign(this, ApplicationUser.map(data || {}));
  }
}


export interface Event extends Model<typeof metadata.Event> {
  eventId: string | null
  name: string | null
  start: Date | null
  end: Date | null
  organizationId: string | null
  organization: Organization | null
}
export class Event {
  
  /** Mutates the input object and its descendents into a valid Event implementation. */
  static convert(data?: Partial<Event>): Event {
    return convertToModel(data || {}, metadata.Event) 
  }
  
  /** Maps the input object and its descendents to a new, valid Event implementation. */
  static map(data?: Partial<Event>): Event {
    return mapToModel(data || {}, metadata.Event) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Event; }
  
  /** Instantiate a new Event, optionally basing it on the given data. */
  constructor(data?: Partial<Event> | {[k: string]: any}) {
    Object.assign(this, Event.map(data || {}));
  }
}


export interface Organization extends Model<typeof metadata.Organization> {
  organizationId: string | null
  name: string | null
}
export class Organization {
  
  /** Mutates the input object and its descendents into a valid Organization implementation. */
  static convert(data?: Partial<Organization>): Organization {
    return convertToModel(data || {}, metadata.Organization) 
  }
  
  /** Maps the input object and its descendents to a new, valid Organization implementation. */
  static map(data?: Partial<Organization>): Organization {
    return mapToModel(data || {}, metadata.Organization) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.Organization; }
  
  /** Instantiate a new Organization, optionally basing it on the given data. */
  constructor(data?: Partial<Organization> | {[k: string]: any}) {
    Object.assign(this, Organization.map(data || {}));
  }
}


export interface TriviaAnswer extends Model<typeof metadata.TriviaAnswer> {
  triviaAnswerId: number | null
  text: string | null
  isCorrect: boolean | null
  triviaQuestionId: number | null
  triviaQuestion: TriviaQuestion | null
  eventId: string | null
  event: Event | null
}
export class TriviaAnswer {
  
  /** Mutates the input object and its descendents into a valid TriviaAnswer implementation. */
  static convert(data?: Partial<TriviaAnswer>): TriviaAnswer {
    return convertToModel(data || {}, metadata.TriviaAnswer) 
  }
  
  /** Maps the input object and its descendents to a new, valid TriviaAnswer implementation. */
  static map(data?: Partial<TriviaAnswer>): TriviaAnswer {
    return mapToModel(data || {}, metadata.TriviaAnswer) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.TriviaAnswer; }
  
  /** Instantiate a new TriviaAnswer, optionally basing it on the given data. */
  constructor(data?: Partial<TriviaAnswer> | {[k: string]: any}) {
    Object.assign(this, TriviaAnswer.map(data || {}));
  }
}


export interface TriviaGuess extends Model<typeof metadata.TriviaGuess> {
  triviaGuessId: number | null
  applicationUserId: string | null
  applicationUser: ApplicationUser | null
  triviaAnswerId: number | null
  triviaAnswer: TriviaAnswer | null
  eventId: string | null
  event: Event | null
}
export class TriviaGuess {
  
  /** Mutates the input object and its descendents into a valid TriviaGuess implementation. */
  static convert(data?: Partial<TriviaGuess>): TriviaGuess {
    return convertToModel(data || {}, metadata.TriviaGuess) 
  }
  
  /** Maps the input object and its descendents to a new, valid TriviaGuess implementation. */
  static map(data?: Partial<TriviaGuess>): TriviaGuess {
    return mapToModel(data || {}, metadata.TriviaGuess) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.TriviaGuess; }
  
  /** Instantiate a new TriviaGuess, optionally basing it on the given data. */
  constructor(data?: Partial<TriviaGuess> | {[k: string]: any}) {
    Object.assign(this, TriviaGuess.map(data || {}));
  }
}


export interface TriviaQuestion extends Model<typeof metadata.TriviaQuestion> {
  triviaQuestionId: number | null
  text: string | null
  answers: TriviaAnswer[] | null
  questionTags: TriviaQuestionTag[] | null
  eventId: string | null
  event: Event | null
}
export class TriviaQuestion {
  
  /** Mutates the input object and its descendents into a valid TriviaQuestion implementation. */
  static convert(data?: Partial<TriviaQuestion>): TriviaQuestion {
    return convertToModel(data || {}, metadata.TriviaQuestion) 
  }
  
  /** Maps the input object and its descendents to a new, valid TriviaQuestion implementation. */
  static map(data?: Partial<TriviaQuestion>): TriviaQuestion {
    return mapToModel(data || {}, metadata.TriviaQuestion) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.TriviaQuestion; }
  
  /** Instantiate a new TriviaQuestion, optionally basing it on the given data. */
  constructor(data?: Partial<TriviaQuestion> | {[k: string]: any}) {
    Object.assign(this, TriviaQuestion.map(data || {}));
  }
}


export interface TriviaQuestionTag extends Model<typeof metadata.TriviaQuestionTag> {
  triviaQuestionTagId: number | null
  triviaQuestionId: number | null
  triviaQuestion: TriviaQuestion | null
  triviaTagId: number | null
  triviaTag: TriviaTag | null
}
export class TriviaQuestionTag {
  
  /** Mutates the input object and its descendents into a valid TriviaQuestionTag implementation. */
  static convert(data?: Partial<TriviaQuestionTag>): TriviaQuestionTag {
    return convertToModel(data || {}, metadata.TriviaQuestionTag) 
  }
  
  /** Maps the input object and its descendents to a new, valid TriviaQuestionTag implementation. */
  static map(data?: Partial<TriviaQuestionTag>): TriviaQuestionTag {
    return mapToModel(data || {}, metadata.TriviaQuestionTag) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.TriviaQuestionTag; }
  
  /** Instantiate a new TriviaQuestionTag, optionally basing it on the given data. */
  constructor(data?: Partial<TriviaQuestionTag> | {[k: string]: any}) {
    Object.assign(this, TriviaQuestionTag.map(data || {}));
  }
}


export interface TriviaTag extends Model<typeof metadata.TriviaTag> {
  triviaTagId: number | null
  name: string | null
}
export class TriviaTag {
  
  /** Mutates the input object and its descendents into a valid TriviaTag implementation. */
  static convert(data?: Partial<TriviaTag>): TriviaTag {
    return convertToModel(data || {}, metadata.TriviaTag) 
  }
  
  /** Maps the input object and its descendents to a new, valid TriviaTag implementation. */
  static map(data?: Partial<TriviaTag>): TriviaTag {
    return mapToModel(data || {}, metadata.TriviaTag) 
  }
  
  static [Symbol.hasInstance](x: any) { return x?.$metadata === metadata.TriviaTag; }
  
  /** Instantiate a new TriviaTag, optionally basing it on the given data. */
  constructor(data?: Partial<TriviaTag> | {[k: string]: any}) {
    Object.assign(this, TriviaTag.map(data || {}));
  }
}


