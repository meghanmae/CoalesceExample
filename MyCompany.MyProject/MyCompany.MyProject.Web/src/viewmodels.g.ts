import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface ApplicationUserViewModel extends $models.ApplicationUser {
  applicationUserId: string | null;
  name: string | null;
  email: string | null;
  organizationId: string | null;
  organization: OrganizationViewModel | null;
}
export class ApplicationUserViewModel extends ViewModel<$models.ApplicationUser, $apiClients.ApplicationUserApiClient, string> implements $models.ApplicationUser  {
  
  constructor(initialData?: DeepPartial<$models.ApplicationUser> | null) {
    super($metadata.ApplicationUser, new $apiClients.ApplicationUserApiClient(), initialData)
  }
}
defineProps(ApplicationUserViewModel, $metadata.ApplicationUser)

export class ApplicationUserListViewModel extends ListViewModel<$models.ApplicationUser, $apiClients.ApplicationUserApiClient, ApplicationUserViewModel> {
  
  constructor() {
    super($metadata.ApplicationUser, new $apiClients.ApplicationUserApiClient())
  }
}


export interface EventViewModel extends $models.Event {
  eventId: string | null;
  name: string | null;
  start: Date | null;
  end: Date | null;
  questions: TriviaQuestionViewModel[] | null;
  organizationId: string | null;
  organization: OrganizationViewModel | null;
}
export class EventViewModel extends ViewModel<$models.Event, $apiClients.EventApiClient, string> implements $models.Event  {
  
  
  public addToQuestions(initialData?: DeepPartial<$models.TriviaQuestion> | null) {
    return this.$addChild('questions', initialData) as TriviaQuestionViewModel
  }
  
  constructor(initialData?: DeepPartial<$models.Event> | null) {
    super($metadata.Event, new $apiClients.EventApiClient(), initialData)
  }
}
defineProps(EventViewModel, $metadata.Event)

export class EventListViewModel extends ListViewModel<$models.Event, $apiClients.EventApiClient, EventViewModel> {
  
  constructor() {
    super($metadata.Event, new $apiClients.EventApiClient())
  }
}


export interface OrganizationViewModel extends $models.Organization {
  organizationId: string | null;
  name: string | null;
}
export class OrganizationViewModel extends ViewModel<$models.Organization, $apiClients.OrganizationApiClient, string> implements $models.Organization  {
  
  constructor(initialData?: DeepPartial<$models.Organization> | null) {
    super($metadata.Organization, new $apiClients.OrganizationApiClient(), initialData)
  }
}
defineProps(OrganizationViewModel, $metadata.Organization)

export class OrganizationListViewModel extends ListViewModel<$models.Organization, $apiClients.OrganizationApiClient, OrganizationViewModel> {
  
  constructor() {
    super($metadata.Organization, new $apiClients.OrganizationApiClient())
  }
}


export interface TriviaAnswerViewModel extends $models.TriviaAnswer {
  triviaAnswerId: number | null;
  text: string | null;
  isCorrect: boolean | null;
  triviaQuestionId: number | null;
  triviaQuestion: TriviaQuestionViewModel | null;
  eventId: string | null;
  event: EventViewModel | null;
}
export class TriviaAnswerViewModel extends ViewModel<$models.TriviaAnswer, $apiClients.TriviaAnswerApiClient, number> implements $models.TriviaAnswer  {
  
  constructor(initialData?: DeepPartial<$models.TriviaAnswer> | null) {
    super($metadata.TriviaAnswer, new $apiClients.TriviaAnswerApiClient(), initialData)
  }
}
defineProps(TriviaAnswerViewModel, $metadata.TriviaAnswer)

export class TriviaAnswerListViewModel extends ListViewModel<$models.TriviaAnswer, $apiClients.TriviaAnswerApiClient, TriviaAnswerViewModel> {
  
  constructor() {
    super($metadata.TriviaAnswer, new $apiClients.TriviaAnswerApiClient())
  }
}


export interface TriviaGuessViewModel extends $models.TriviaGuess {
  triviaGuessId: number | null;
  applicationUserId: string | null;
  applicationUser: ApplicationUserViewModel | null;
  triviaAnswerId: number | null;
  triviaAnswer: TriviaAnswerViewModel | null;
  eventId: string | null;
  event: EventViewModel | null;
}
export class TriviaGuessViewModel extends ViewModel<$models.TriviaGuess, $apiClients.TriviaGuessApiClient, number> implements $models.TriviaGuess  {
  
  constructor(initialData?: DeepPartial<$models.TriviaGuess> | null) {
    super($metadata.TriviaGuess, new $apiClients.TriviaGuessApiClient(), initialData)
  }
}
defineProps(TriviaGuessViewModel, $metadata.TriviaGuess)

export class TriviaGuessListViewModel extends ListViewModel<$models.TriviaGuess, $apiClients.TriviaGuessApiClient, TriviaGuessViewModel> {
  
  constructor() {
    super($metadata.TriviaGuess, new $apiClients.TriviaGuessApiClient())
  }
}


export interface TriviaQuestionViewModel extends $models.TriviaQuestion {
  triviaQuestionId: number | null;
  text: string | null;
  answers: TriviaAnswerViewModel[] | null;
  questionTags: TriviaQuestionTagViewModel[] | null;
  eventId: string | null;
  event: EventViewModel | null;
}
export class TriviaQuestionViewModel extends ViewModel<$models.TriviaQuestion, $apiClients.TriviaQuestionApiClient, number> implements $models.TriviaQuestion  {
  
  
  public addToAnswers(initialData?: DeepPartial<$models.TriviaAnswer> | null) {
    return this.$addChild('answers', initialData) as TriviaAnswerViewModel
  }
  
  
  public addToQuestionTags(initialData?: DeepPartial<$models.TriviaQuestionTag> | null) {
    return this.$addChild('questionTags', initialData) as TriviaQuestionTagViewModel
  }
  
  get triviaTag(): ReadonlyArray<TriviaTagViewModel> {
    return (this.questionTags || []).map($ => $.triviaTag!).filter($ => $)
  }
  
  constructor(initialData?: DeepPartial<$models.TriviaQuestion> | null) {
    super($metadata.TriviaQuestion, new $apiClients.TriviaQuestionApiClient(), initialData)
  }
}
defineProps(TriviaQuestionViewModel, $metadata.TriviaQuestion)

export class TriviaQuestionListViewModel extends ListViewModel<$models.TriviaQuestion, $apiClients.TriviaQuestionApiClient, TriviaQuestionViewModel> {
  
  constructor() {
    super($metadata.TriviaQuestion, new $apiClients.TriviaQuestionApiClient())
  }
}


export interface TriviaQuestionTagViewModel extends $models.TriviaQuestionTag {
  triviaQuestionTagId: number | null;
  triviaQuestionId: number | null;
  triviaQuestion: TriviaQuestionViewModel | null;
  triviaTagId: number | null;
  triviaTag: TriviaTagViewModel | null;
}
export class TriviaQuestionTagViewModel extends ViewModel<$models.TriviaQuestionTag, $apiClients.TriviaQuestionTagApiClient, number> implements $models.TriviaQuestionTag  {
  
  constructor(initialData?: DeepPartial<$models.TriviaQuestionTag> | null) {
    super($metadata.TriviaQuestionTag, new $apiClients.TriviaQuestionTagApiClient(), initialData)
  }
}
defineProps(TriviaQuestionTagViewModel, $metadata.TriviaQuestionTag)

export class TriviaQuestionTagListViewModel extends ListViewModel<$models.TriviaQuestionTag, $apiClients.TriviaQuestionTagApiClient, TriviaQuestionTagViewModel> {
  
  constructor() {
    super($metadata.TriviaQuestionTag, new $apiClients.TriviaQuestionTagApiClient())
  }
}


export interface TriviaTagViewModel extends $models.TriviaTag {
  triviaTagId: number | null;
  name: string | null;
}
export class TriviaTagViewModel extends ViewModel<$models.TriviaTag, $apiClients.TriviaTagApiClient, number> implements $models.TriviaTag  {
  
  constructor(initialData?: DeepPartial<$models.TriviaTag> | null) {
    super($metadata.TriviaTag, new $apiClients.TriviaTagApiClient(), initialData)
  }
}
defineProps(TriviaTagViewModel, $metadata.TriviaTag)

export class TriviaTagListViewModel extends ListViewModel<$models.TriviaTag, $apiClients.TriviaTagApiClient, TriviaTagViewModel> {
  
  constructor() {
    super($metadata.TriviaTag, new $apiClients.TriviaTagApiClient())
  }
}


const viewModelTypeLookup = ViewModel.typeLookup = {
  ApplicationUser: ApplicationUserViewModel,
  Event: EventViewModel,
  Organization: OrganizationViewModel,
  TriviaAnswer: TriviaAnswerViewModel,
  TriviaGuess: TriviaGuessViewModel,
  TriviaQuestion: TriviaQuestionViewModel,
  TriviaQuestionTag: TriviaQuestionTagViewModel,
  TriviaTag: TriviaTagViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  ApplicationUser: ApplicationUserListViewModel,
  Event: EventListViewModel,
  Organization: OrganizationListViewModel,
  TriviaAnswer: TriviaAnswerListViewModel,
  TriviaGuess: TriviaGuessListViewModel,
  TriviaQuestion: TriviaQuestionListViewModel,
  TriviaQuestionTag: TriviaQuestionTagListViewModel,
  TriviaTag: TriviaTagListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

