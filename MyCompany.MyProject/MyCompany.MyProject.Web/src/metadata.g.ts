import {
  Domain, getEnumMeta, solidify, ModelType, ObjectType,
  PrimitiveProperty, ForeignKeyProperty, PrimaryKeyProperty,
  ModelCollectionNavigationProperty, ModelReferenceNavigationProperty,
  HiddenAreas, BehaviorFlags
} from 'coalesce-vue/lib/metadata'


const domain: Domain = { enums: {}, types: {}, services: {} }
export const ApplicationUser = domain.types.ApplicationUser = {
  name: "ApplicationUser",
  displayName: "Application User",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "ApplicationUser",
  get keyProp() { return this.props.applicationUserId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    applicationUserId: {
      name: "applicationUserId",
      displayName: "Application User Id",
      type: "string",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    email: {
      name: "email",
      displayName: "Email",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Email is required.",
      }
    },
    organizationId: {
      name: "organizationId",
      displayName: "Organization Id",
      type: "string",
      role: "foreignKey",
      get principalKey() { return (domain.types.Organization as ModelType).props.organizationId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Organization as ModelType) },
      get navigationProp() { return (domain.types.ApplicationUser as ModelType).props.organization as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => (val != null && val !== '') || "Organization is required.",
      }
    },
    organization: {
      name: "organization",
      displayName: "Organization",
      type: "model",
      get typeDef() { return (domain.types.Organization as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.ApplicationUser as ModelType).props.organizationId as ForeignKeyProperty },
      get principalKey() { return (domain.types.Organization as ModelType).props.organizationId as PrimaryKeyProperty },
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Event = domain.types.Event = {
  name: "Event",
  displayName: "Event",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Event",
  get keyProp() { return this.props.eventId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    eventId: {
      name: "eventId",
      displayName: "Event Id",
      type: "string",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    start: {
      name: "start",
      displayName: "Start",
      type: "date",
      dateKind: "datetime",
      role: "value",
      rules: {
        required: val => val != null || "Start is required.",
      }
    },
    end: {
      name: "end",
      displayName: "End",
      type: "date",
      dateKind: "datetime",
      role: "value",
      rules: {
        required: val => val != null || "End is required.",
      }
    },
    questions: {
      name: "questions",
      displayName: "Questions",
      type: "collection",
      itemType: {
        name: "$collectionItem",
        displayName: "",
        role: "value",
        type: "model",
        get typeDef() { return (domain.types.TriviaQuestion as ModelType) },
      },
      role: "collectionNavigation",
      get foreignKey() { return (domain.types.TriviaQuestion as ModelType).props.eventId as ForeignKeyProperty },
      get inverseNavigation() { return (domain.types.TriviaQuestion as ModelType).props.event as ModelReferenceNavigationProperty },
      dontSerialize: true,
    },
    organizationId: {
      name: "organizationId",
      displayName: "Organization Id",
      type: "string",
      role: "foreignKey",
      get principalKey() { return (domain.types.Organization as ModelType).props.organizationId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Organization as ModelType) },
      get navigationProp() { return (domain.types.Event as ModelType).props.organization as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => (val != null && val !== '') || "Organization is required.",
      }
    },
    organization: {
      name: "organization",
      displayName: "Organization",
      type: "model",
      get typeDef() { return (domain.types.Organization as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.Event as ModelType).props.organizationId as ForeignKeyProperty },
      get principalKey() { return (domain.types.Organization as ModelType).props.organizationId as PrimaryKeyProperty },
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
    eventWithOrgDataSource: {
      type: "dataSource",
      name: "EventWithOrgDataSource",
      displayName: "Event With Org Data Source",
      props: {
      },
    },
  },
}
export const Organization = domain.types.Organization = {
  name: "Organization",
  displayName: "Organization",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Organization",
  get keyProp() { return this.props.organizationId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    organizationId: {
      name: "organizationId",
      displayName: "Organization Id",
      type: "string",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const TriviaAnswer = domain.types.TriviaAnswer = {
  name: "TriviaAnswer",
  displayName: "Trivia Answer",
  get displayProp() { return this.props.triviaAnswerId }, 
  type: "model",
  controllerRoute: "TriviaAnswer",
  get keyProp() { return this.props.triviaAnswerId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    triviaAnswerId: {
      name: "triviaAnswerId",
      displayName: "Trivia Answer Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    text: {
      name: "text",
      displayName: "Text",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Text is required.",
      }
    },
    isCorrect: {
      name: "isCorrect",
      displayName: "Is Correct",
      type: "boolean",
      role: "value",
      rules: {
        required: val => val != null || "Is Correct is required.",
      }
    },
    triviaQuestionId: {
      name: "triviaQuestionId",
      displayName: "Trivia Question Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.TriviaQuestion as ModelType).props.triviaQuestionId as PrimaryKeyProperty },
      get principalType() { return (domain.types.TriviaQuestion as ModelType) },
      get navigationProp() { return (domain.types.TriviaAnswer as ModelType).props.triviaQuestion as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Trivia Question is required.",
      }
    },
    triviaQuestion: {
      name: "triviaQuestion",
      displayName: "Trivia Question",
      type: "model",
      get typeDef() { return (domain.types.TriviaQuestion as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TriviaAnswer as ModelType).props.triviaQuestionId as ForeignKeyProperty },
      get principalKey() { return (domain.types.TriviaQuestion as ModelType).props.triviaQuestionId as PrimaryKeyProperty },
      get inverseNavigation() { return (domain.types.TriviaQuestion as ModelType).props.answers as ModelCollectionNavigationProperty },
      dontSerialize: true,
    },
    eventId: {
      name: "eventId",
      displayName: "Event Id",
      type: "string",
      role: "foreignKey",
      get principalKey() { return (domain.types.Event as ModelType).props.eventId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Event as ModelType) },
      get navigationProp() { return (domain.types.TriviaAnswer as ModelType).props.event as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => (val != null && val !== '') || "Event is required.",
      }
    },
    event: {
      name: "event",
      displayName: "Event",
      type: "model",
      get typeDef() { return (domain.types.Event as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TriviaAnswer as ModelType).props.eventId as ForeignKeyProperty },
      get principalKey() { return (domain.types.Event as ModelType).props.eventId as PrimaryKeyProperty },
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const TriviaGuess = domain.types.TriviaGuess = {
  name: "TriviaGuess",
  displayName: "Trivia Guess",
  get displayProp() { return this.props.triviaGuessId }, 
  type: "model",
  controllerRoute: "TriviaGuess",
  get keyProp() { return this.props.triviaGuessId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    triviaGuessId: {
      name: "triviaGuessId",
      displayName: "Trivia Guess Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    applicationUserId: {
      name: "applicationUserId",
      displayName: "Application User Id",
      type: "string",
      role: "foreignKey",
      get principalKey() { return (domain.types.ApplicationUser as ModelType).props.applicationUserId as PrimaryKeyProperty },
      get principalType() { return (domain.types.ApplicationUser as ModelType) },
      get navigationProp() { return (domain.types.TriviaGuess as ModelType).props.applicationUser as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => (val != null && val !== '') || "Application User is required.",
      }
    },
    applicationUser: {
      name: "applicationUser",
      displayName: "Application User",
      type: "model",
      get typeDef() { return (domain.types.ApplicationUser as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TriviaGuess as ModelType).props.applicationUserId as ForeignKeyProperty },
      get principalKey() { return (domain.types.ApplicationUser as ModelType).props.applicationUserId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    triviaAnswerId: {
      name: "triviaAnswerId",
      displayName: "Trivia Answer Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.TriviaAnswer as ModelType).props.triviaAnswerId as PrimaryKeyProperty },
      get principalType() { return (domain.types.TriviaAnswer as ModelType) },
      get navigationProp() { return (domain.types.TriviaGuess as ModelType).props.triviaAnswer as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Trivia Answer is required.",
      }
    },
    triviaAnswer: {
      name: "triviaAnswer",
      displayName: "Trivia Answer",
      type: "model",
      get typeDef() { return (domain.types.TriviaAnswer as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TriviaGuess as ModelType).props.triviaAnswerId as ForeignKeyProperty },
      get principalKey() { return (domain.types.TriviaAnswer as ModelType).props.triviaAnswerId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    eventId: {
      name: "eventId",
      displayName: "Event Id",
      type: "string",
      role: "foreignKey",
      get principalKey() { return (domain.types.Event as ModelType).props.eventId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Event as ModelType) },
      get navigationProp() { return (domain.types.TriviaGuess as ModelType).props.event as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => (val != null && val !== '') || "Event is required.",
      }
    },
    event: {
      name: "event",
      displayName: "Event",
      type: "model",
      get typeDef() { return (domain.types.Event as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TriviaGuess as ModelType).props.eventId as ForeignKeyProperty },
      get principalKey() { return (domain.types.Event as ModelType).props.eventId as PrimaryKeyProperty },
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const TriviaQuestion = domain.types.TriviaQuestion = {
  name: "TriviaQuestion",
  displayName: "Trivia Question",
  get displayProp() { return this.props.triviaQuestionId }, 
  type: "model",
  controllerRoute: "TriviaQuestion",
  get keyProp() { return this.props.triviaQuestionId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    triviaQuestionId: {
      name: "triviaQuestionId",
      displayName: "Trivia Question Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    text: {
      name: "text",
      displayName: "Text",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Text is required.",
      }
    },
    answers: {
      name: "answers",
      displayName: "Answers",
      type: "collection",
      itemType: {
        name: "$collectionItem",
        displayName: "",
        role: "value",
        type: "model",
        get typeDef() { return (domain.types.TriviaAnswer as ModelType) },
      },
      role: "collectionNavigation",
      get foreignKey() { return (domain.types.TriviaAnswer as ModelType).props.triviaQuestionId as ForeignKeyProperty },
      get inverseNavigation() { return (domain.types.TriviaAnswer as ModelType).props.triviaQuestion as ModelReferenceNavigationProperty },
      dontSerialize: true,
    },
    questionTags: {
      name: "questionTags",
      displayName: "Question Tags",
      type: "collection",
      itemType: {
        name: "$collectionItem",
        displayName: "",
        role: "value",
        type: "model",
        get typeDef() { return (domain.types.TriviaQuestionTag as ModelType) },
      },
      role: "collectionNavigation",
      get foreignKey() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaQuestionId as ForeignKeyProperty },
      get inverseNavigation() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaQuestion as ModelReferenceNavigationProperty },
      manyToMany: {
        name: "triviaTag",
        displayName: "Trivia Tag",
        get typeDef() { return (domain.types.TriviaTag as ModelType) },
        get farForeignKey() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaTagId as ForeignKeyProperty },
        get farNavigationProp() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaTag as ModelReferenceNavigationProperty },
        get nearForeignKey() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaQuestionId as ForeignKeyProperty },
        get nearNavigationProp() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaQuestion as ModelReferenceNavigationProperty },
      },
      dontSerialize: true,
    },
    eventId: {
      name: "eventId",
      displayName: "Event Id",
      type: "string",
      role: "foreignKey",
      get principalKey() { return (domain.types.Event as ModelType).props.eventId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Event as ModelType) },
      get navigationProp() { return (domain.types.TriviaQuestion as ModelType).props.event as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => (val != null && val !== '') || "Event is required.",
      }
    },
    event: {
      name: "event",
      displayName: "Event",
      type: "model",
      get typeDef() { return (domain.types.Event as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TriviaQuestion as ModelType).props.eventId as ForeignKeyProperty },
      get principalKey() { return (domain.types.Event as ModelType).props.eventId as PrimaryKeyProperty },
      get inverseNavigation() { return (domain.types.Event as ModelType).props.questions as ModelCollectionNavigationProperty },
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
    triviaQuestionsByEventDataSource: {
      type: "dataSource",
      name: "TriviaQuestionsByEventDataSource",
      displayName: "Trivia Questions By Event Data Source",
      props: {
        eventId: {
          name: "eventId",
          displayName: "Event Id",
          type: "string",
          role: "value",
        },
      },
    },
  },
}
export const TriviaQuestionTag = domain.types.TriviaQuestionTag = {
  name: "TriviaQuestionTag",
  displayName: "Trivia Question Tag",
  get displayProp() { return this.props.triviaQuestionTagId }, 
  type: "model",
  controllerRoute: "TriviaQuestionTag",
  get keyProp() { return this.props.triviaQuestionTagId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    triviaQuestionTagId: {
      name: "triviaQuestionTagId",
      displayName: "Trivia Question Tag Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    triviaQuestionId: {
      name: "triviaQuestionId",
      displayName: "Trivia Question Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.TriviaQuestion as ModelType).props.triviaQuestionId as PrimaryKeyProperty },
      get principalType() { return (domain.types.TriviaQuestion as ModelType) },
      get navigationProp() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaQuestion as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Trivia Question is required.",
      }
    },
    triviaQuestion: {
      name: "triviaQuestion",
      displayName: "Trivia Question",
      type: "model",
      get typeDef() { return (domain.types.TriviaQuestion as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaQuestionId as ForeignKeyProperty },
      get principalKey() { return (domain.types.TriviaQuestion as ModelType).props.triviaQuestionId as PrimaryKeyProperty },
      get inverseNavigation() { return (domain.types.TriviaQuestion as ModelType).props.questionTags as ModelCollectionNavigationProperty },
      dontSerialize: true,
    },
    triviaTagId: {
      name: "triviaTagId",
      displayName: "Trivia Tag Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.TriviaTag as ModelType).props.triviaTagId as PrimaryKeyProperty },
      get principalType() { return (domain.types.TriviaTag as ModelType) },
      get navigationProp() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaTag as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Trivia Tag is required.",
      }
    },
    triviaTag: {
      name: "triviaTag",
      displayName: "Trivia Tag",
      type: "model",
      get typeDef() { return (domain.types.TriviaTag as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.TriviaQuestionTag as ModelType).props.triviaTagId as ForeignKeyProperty },
      get principalKey() { return (domain.types.TriviaTag as ModelType).props.triviaTagId as PrimaryKeyProperty },
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const TriviaTag = domain.types.TriviaTag = {
  name: "TriviaTag",
  displayName: "Trivia Tag",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "TriviaTag",
  get keyProp() { return this.props.triviaTagId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    triviaTagId: {
      name: "triviaTagId",
      displayName: "Trivia Tag Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
  },
  methods: {
  },
  dataSources: {
  },
}

interface AppDomain extends Domain {
  enums: {
  }
  types: {
    ApplicationUser: typeof ApplicationUser
    Event: typeof Event
    Organization: typeof Organization
    TriviaAnswer: typeof TriviaAnswer
    TriviaGuess: typeof TriviaGuess
    TriviaQuestion: typeof TriviaQuestion
    TriviaQuestionTag: typeof TriviaQuestionTag
    TriviaTag: typeof TriviaTag
  }
  services: {
  }
}

solidify(domain)

export default domain as unknown as AppDomain
